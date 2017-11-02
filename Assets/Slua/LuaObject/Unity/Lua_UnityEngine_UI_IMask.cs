using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_IMask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MaskEnabled(IntPtr l) {
		try {
			UnityEngine.UI.IMask self=(UnityEngine.UI.IMask)checkSelf(l);
			var ret=self.MaskEnabled();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.IMask");
		addMember(l,MaskEnabled);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.IMask));
	}
}
