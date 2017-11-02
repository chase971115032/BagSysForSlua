using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_FixedJoint : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.FixedJoint");
		createTypeMetatable(l,null, typeof(UnityEngine.FixedJoint),typeof(UnityEngine.Joint));
	}
}
