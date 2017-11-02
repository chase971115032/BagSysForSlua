using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_IEventSystemHandler : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.IEventSystemHandler");
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.IEventSystemHandler));
	}
}
