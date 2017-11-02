using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ILayoutSelfController : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ILayoutSelfController");
		createTypeMetatable(l,null, typeof(UnityEngine.UI.ILayoutSelfController));
	}
}
