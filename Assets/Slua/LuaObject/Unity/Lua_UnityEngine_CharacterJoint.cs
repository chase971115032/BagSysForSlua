﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CharacterJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swingAxis(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.swingAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swingAxis(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.swingAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowTwistLimit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lowTwistLimit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowTwistLimit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.SoftJointLimit v;
			checkValueType(l,2,out v);
			self.lowTwistLimit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highTwistLimit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.highTwistLimit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highTwistLimit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.SoftJointLimit v;
			checkValueType(l,2,out v);
			self.highTwistLimit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing1Limit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.swing1Limit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing1Limit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.SoftJointLimit v;
			checkValueType(l,2,out v);
			self.swing1Limit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing2Limit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.swing2Limit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing2Limit(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.SoftJointLimit v;
			checkValueType(l,2,out v);
			self.swing2Limit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRotation(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRotation(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.targetRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetAngularVelocity(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetAngularVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetAngularVelocity(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.targetAngularVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationDrive(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotationDrive);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationDrive(IntPtr l) {
		try {
			UnityEngine.CharacterJoint self=(UnityEngine.CharacterJoint)checkSelf(l);
			UnityEngine.JointDrive v;
			checkValueType(l,2,out v);
			self.rotationDrive=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterJoint");
		addMember(l,"swingAxis",get_swingAxis,set_swingAxis,true);
		addMember(l,"lowTwistLimit",get_lowTwistLimit,set_lowTwistLimit,true);
		addMember(l,"highTwistLimit",get_highTwistLimit,set_highTwistLimit,true);
		addMember(l,"swing1Limit",get_swing1Limit,set_swing1Limit,true);
		addMember(l,"swing2Limit",get_swing2Limit,set_swing2Limit,true);
		addMember(l,"targetRotation",get_targetRotation,set_targetRotation,true);
		addMember(l,"targetAngularVelocity",get_targetAngularVelocity,set_targetAngularVelocity,true);
		addMember(l,"rotationDrive",get_rotationDrive,set_rotationDrive,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CharacterJoint),typeof(UnityEngine.Joint));
	}
}
