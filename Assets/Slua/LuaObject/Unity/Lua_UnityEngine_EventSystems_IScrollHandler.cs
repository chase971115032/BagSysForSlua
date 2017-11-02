using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_IScrollHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnScroll(IntPtr l) {
		try {
			UnityEngine.EventSystems.IScrollHandler self=(UnityEngine.EventSystems.IScrollHandler)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnScroll(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.IScrollHandler");
		addMember(l,OnScroll);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IScrollHandler));
	}
}
