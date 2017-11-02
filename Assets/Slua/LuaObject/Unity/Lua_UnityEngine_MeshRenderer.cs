using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshRenderer : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshRenderer");
		createTypeMetatable(l,null, typeof(UnityEngine.MeshRenderer),typeof(UnityEngine.Renderer));
	}
}
