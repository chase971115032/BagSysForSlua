using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapPoint(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.OverlapPoint(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTrigger(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isTrigger);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isTrigger(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isTrigger=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachedRigidbody(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.attachedRigidbody);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shapeCount(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shapeCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sharedMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		try {
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			UnityEngine.PhysicsMaterial2D v;
			checkType(l,2,out v);
			self.sharedMaterial=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collider2D");
		addMember(l,OverlapPoint);
		addMember(l,"isTrigger",get_isTrigger,set_isTrigger,true);
		addMember(l,"attachedRigidbody",get_attachedRigidbody,null,true);
		addMember(l,"shapeCount",get_shapeCount,null,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"sharedMaterial",get_sharedMaterial,set_sharedMaterial,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Collider2D),typeof(UnityEngine.Behaviour));
	}
}
