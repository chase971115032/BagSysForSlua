using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SLua;
using DG.Tweening;

[CustomLuaClass]
public class ToSluaTool
{
    //设置 Image 的 Sprite
    public static void SetImageSprite(Image image,Sprite sprite)
    {
        image.sprite = sprite;
    }

    //将 屏幕坐标 转换成 UGUI坐标
    public static Vector2 ScreenToWorld(RectTransform rect,Vector2 vec)
    {
        Vector2 loc;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(rect,vec,Camera.main,out loc))
        {

        }
        else
        {
            Debug.Log("坐标转换失败！");
        }
        return loc;
    }

    //DoTween 移动
    public static void MoveToWords(RectTransform rect,Vector3 targetPos,float time,TweenCallback callback)
    {
        rect.DOLocalMove(targetPos, time).OnComplete(callback);
    }
}
