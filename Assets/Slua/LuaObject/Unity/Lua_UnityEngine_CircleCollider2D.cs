using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CircleCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.CircleCollider2D self=(UnityEngine.CircleCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.center);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		try {
			UnityEngine.CircleCollider2D self=(UnityEngine.CircleCollider2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.center=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.CircleCollider2D self=(UnityEngine.CircleCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.radius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.CircleCollider2D self=(UnityEngine.CircleCollider2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.radius=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CircleCollider2D");
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"radius",get_radius,set_radius,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CircleCollider2D),typeof(UnityEngine.Collider2D));
	}
}
