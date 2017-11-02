using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ClothRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pauseWhenNotVisible(IntPtr l) {
		try {
			UnityEngine.ClothRenderer self=(UnityEngine.ClothRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pauseWhenNotVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pauseWhenNotVisible(IntPtr l) {
		try {
			UnityEngine.ClothRenderer self=(UnityEngine.ClothRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.pauseWhenNotVisible=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ClothRenderer");
		addMember(l,"pauseWhenNotVisible",get_pauseWhenNotVisible,set_pauseWhenNotVisible,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ClothRenderer),typeof(UnityEngine.Renderer));
	}
}
