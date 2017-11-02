using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ILayoutController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		try {
			UnityEngine.UI.ILayoutController self=(UnityEngine.UI.ILayoutController)checkSelf(l);
			self.SetLayoutHorizontal();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutVertical(IntPtr l) {
		try {
			UnityEngine.UI.ILayoutController self=(UnityEngine.UI.ILayoutController)checkSelf(l);
			self.SetLayoutVertical();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ILayoutController");
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.ILayoutController));
	}
}
