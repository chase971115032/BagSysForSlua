﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_IPointerDownHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerDown(IntPtr l) {
		try {
			UnityEngine.EventSystems.IPointerDownHandler self=(UnityEngine.EventSystems.IPointerDownHandler)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.IPointerDownHandler");
		addMember(l,OnPointerDown);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IPointerDownHandler));
	}
}
