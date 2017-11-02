using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SLua;

[CustomLuaClass]
public class UIInterface : MonoBehaviour,IDragHandler,IEndDragHandler,IPointerDownHandler,IPointerUpHandler
{
    // Use this for initialization
    private RectTransform canvasRct;
    void Awake()
    {
        //LuaSvr.mainState.getFunction("Testfff").call("!!!!");
        canvasRct = GameObject.Find("Canvas").GetComponent<RectTransform>();
    }

    void Update()
    {
        Image img;
        img.sprite.name
    }


    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left) return;
        LuaSvr.mainState.getFunction("onDragstart").call(ScreenToUgui(eventData.position));
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left) return;
        LuaSvr.mainState.getFunction("onDragend").call(this.gameObject, ScreenToUgui(eventData.position));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left) return;
        LuaSvr.mainState.getFunction("onPointerDown").call(this.gameObject, ScreenToUgui(eventData.position));

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left) return;
        LuaSvr.mainState.getFunction("onPointerUp").call(eventData.pointerEnter, ScreenToUgui(eventData.position));
    }

    private Vector2 ScreenToUgui(Vector2 vec)
    {
        Vector2 loc = new Vector2();
        bool isOk = RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRct, vec, Camera.main, out loc);
        if (!isOk)
        {
            Debug.LogError("坐标转换失败");
        }
        return loc;
    }
}
