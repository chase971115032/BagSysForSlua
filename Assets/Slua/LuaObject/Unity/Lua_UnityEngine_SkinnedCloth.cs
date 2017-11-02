using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SkinnedCloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEnabledFading(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.SetEnabledFading(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetEnabledFading(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SetEnabledFading to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_coefficients(IntPtr l) {
		try {
			UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.coefficients);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_coefficients(IntPtr l) {
		try {
			UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
			UnityEngine.ClothSkinningCoefficient[] v;
			checkArray(l,2,out v);
			self.coefficients=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldVelocityScale(IntPtr l) {
		try {
			UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldVelocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldVelocityScale(IntPtr l) {
		try {
			UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.worldVelocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldAccelerationScale(IntPtr l) {
		try {
			UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldAccelerationScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldAccelerationScale(IntPtr l) {
		try {
			UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.worldAccelerationScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkinnedCloth");
		addMember(l,SetEnabledFading);
		addMember(l,"coefficients",get_coefficients,set_coefficients,true);
		addMember(l,"worldVelocityScale",get_worldVelocityScale,set_worldVelocityScale,true);
		addMember(l,"worldAccelerationScale",get_worldAccelerationScale,set_worldAccelerationScale,true);
		createTypeMetatable(l,null, typeof(UnityEngine.SkinnedCloth),typeof(UnityEngine.Cloth));
	}
}
