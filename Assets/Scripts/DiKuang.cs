using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using SLua;

[CustomLuaClass]
public class DiKuang : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        LuaSvr.mainState.getFunction("onPointerEnter").call(this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LuaSvr.mainState.getFunction("onPointerExit").call(this.gameObject);
    }
}
