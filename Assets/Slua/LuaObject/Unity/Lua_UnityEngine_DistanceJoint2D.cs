﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DistanceJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionForce(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.GetReactionForce(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionTorque(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.GetReactionTorque(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.distance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.distance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistanceOnly(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxDistanceOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistanceOnly(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.maxDistanceOnly=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DistanceJoint2D");
		addMember(l,GetReactionForce);
		addMember(l,GetReactionTorque);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"maxDistanceOnly",get_maxDistanceOnly,set_maxDistanceOnly,true);
		createTypeMetatable(l,null, typeof(UnityEngine.DistanceJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
