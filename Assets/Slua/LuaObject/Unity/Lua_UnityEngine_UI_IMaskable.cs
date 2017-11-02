using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_IMaskable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParentMaskStateChanged(IntPtr l) {
		try {
			UnityEngine.UI.IMaskable self=(UnityEngine.UI.IMaskable)checkSelf(l);
			self.ParentMaskStateChanged();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.IMaskable");
		addMember(l,ParentMaskStateChanged);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.IMaskable));
	}
}
