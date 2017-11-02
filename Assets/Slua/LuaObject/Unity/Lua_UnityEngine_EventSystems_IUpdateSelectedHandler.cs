using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_IUpdateSelectedHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnUpdateSelected(IntPtr l) {
		try {
			UnityEngine.EventSystems.IUpdateSelectedHandler self=(UnityEngine.EventSystems.IUpdateSelectedHandler)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnUpdateSelected(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.IUpdateSelectedHandler");
		addMember(l,OnUpdateSelected);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IUpdateSelectedHandler));
	}
}
