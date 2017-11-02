﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Joint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedBody(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectedBody);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedBody(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			UnityEngine.Rigidbody2D v;
			checkType(l,2,out v);
			self.connectedBody=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collideConnected(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collideConnected);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collideConnected(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.collideConnected=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint2D");
		addMember(l,"connectedBody",get_connectedBody,set_connectedBody,true);
		addMember(l,"collideConnected",get_collideConnected,set_collideConnected,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Joint2D),typeof(UnityEngine.Behaviour));
	}
}
