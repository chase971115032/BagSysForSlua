using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ILayoutGroup : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ILayoutGroup");
		createTypeMetatable(l,null, typeof(UnityEngine.UI.ILayoutGroup));
	}
}
