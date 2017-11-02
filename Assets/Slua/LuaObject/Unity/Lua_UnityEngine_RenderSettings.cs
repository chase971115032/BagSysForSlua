using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.RenderSettings o;
			o=new UnityEngine.RenderSettings();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fog(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.fog);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fog(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.fog=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fogMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.RenderSettings.fogMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fogMode(IntPtr l) {
		try {
			UnityEngine.FogMode v;
			checkEnum(l,2,out v);
			UnityEngine.RenderSettings.fogMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fogColor(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.fogColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fogColor(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.fogColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fogDensity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.fogDensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fogDensity(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.fogDensity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fogStartDistance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.fogStartDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fogStartDistance(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.fogStartDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fogEndDistance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.fogEndDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fogEndDistance(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.fogEndDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ambientLight(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.ambientLight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ambientLight(IntPtr l) {
		try {
			UnityEngine.Color v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.ambientLight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_haloStrength(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.haloStrength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_haloStrength(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.haloStrength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flareStrength(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.flareStrength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flareStrength(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.flareStrength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flareFadeSpeed(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.flareFadeSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flareFadeSpeed(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.flareFadeSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_skybox(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.RenderSettings.skybox);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_skybox(IntPtr l) {
		try {
			UnityEngine.Material v;
			checkType(l,2,out v);
			UnityEngine.RenderSettings.skybox=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderSettings");
		addMember(l,"fog",get_fog,set_fog,false);
		addMember(l,"fogMode",get_fogMode,set_fogMode,false);
		addMember(l,"fogColor",get_fogColor,set_fogColor,false);
		addMember(l,"fogDensity",get_fogDensity,SLua.RenderSettingsEx.set_fogDensity,false);
		addMember(l,"fogStartDistance",get_fogStartDistance,set_fogStartDistance,false);
		addMember(l,"fogEndDistance",get_fogEndDistance,set_fogEndDistance,false);
		addMember(l,"ambientLight",get_ambientLight,set_ambientLight,false);
		addMember(l,"haloStrength",get_haloStrength,set_haloStrength,false);
		addMember(l,"flareStrength",get_flareStrength,set_flareStrength,false);
		addMember(l,"flareFadeSpeed",get_flareFadeSpeed,set_flareFadeSpeed,false);
		addMember(l,"skybox",get_skybox,set_skybox,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RenderSettings),typeof(UnityEngine.Object));
	}
}
