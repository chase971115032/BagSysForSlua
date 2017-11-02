﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_IMoveHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnMove(IntPtr l) {
		try {
			UnityEngine.EventSystems.IMoveHandler self=(UnityEngine.EventSystems.IMoveHandler)checkSelf(l);
			UnityEngine.EventSystems.AxisEventData a1;
			checkType(l,2,out a1);
			self.OnMove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.IMoveHandler");
		addMember(l,OnMove);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IMoveHandler));
	}
}
