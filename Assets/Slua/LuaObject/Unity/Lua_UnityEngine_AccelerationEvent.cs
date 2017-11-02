﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AccelerationEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AccelerationEvent o;
			o=new UnityEngine.AccelerationEvent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		try {
			UnityEngine.AccelerationEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.acceleration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		try {
			UnityEngine.AccelerationEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.deltaTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AccelerationEvent");
		addMember(l,"acceleration",get_acceleration,null,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AccelerationEvent),typeof(System.ValueType));
	}
}
