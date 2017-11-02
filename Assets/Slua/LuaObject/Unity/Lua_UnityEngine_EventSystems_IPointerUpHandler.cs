using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_IPointerUpHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerUp(IntPtr l) {
		try {
			UnityEngine.EventSystems.IPointerUpHandler self=(UnityEngine.EventSystems.IPointerUpHandler)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.IPointerUpHandler");
		addMember(l,OnPointerUp);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IPointerUpHandler));
	}
}
