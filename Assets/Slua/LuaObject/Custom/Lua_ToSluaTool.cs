using System;
using SLua;
using System.Collections.Generic;
public class Lua_ToSluaTool : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			ToSluaTool o;
			o=new ToSluaTool();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetImageSprite_s(IntPtr l) {
		try {
			UnityEngine.UI.Image a1;
			checkType(l,1,out a1);
			UnityEngine.Sprite a2;
			checkType(l,2,out a2);
			ToSluaTool.SetImageSprite(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToWorld_s(IntPtr l) {
		try {
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			var ret=ToSluaTool.ScreenToWorld(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveToWords_s(IntPtr l) {
		try {
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			DG.Tweening.TweenCallback a4;
			checkDelegate(l,4,out a4);
			ToSluaTool.MoveToWords(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ToSluaTool");
		addMember(l,SetImageSprite_s);
		addMember(l,ScreenToWorld_s);
		addMember(l,MoveToWords_s);
		createTypeMetatable(l,constructor, typeof(ToSluaTool));
	}
}
