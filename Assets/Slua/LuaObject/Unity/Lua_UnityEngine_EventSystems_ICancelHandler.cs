using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_ICancelHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnCancel(IntPtr l) {
		try {
			UnityEngine.EventSystems.ICancelHandler self=(UnityEngine.EventSystems.ICancelHandler)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnCancel(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.ICancelHandler");
		addMember(l,OnCancel);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.ICancelHandler));
	}
}
