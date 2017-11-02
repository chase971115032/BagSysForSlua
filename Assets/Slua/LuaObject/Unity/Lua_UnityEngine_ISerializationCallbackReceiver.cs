using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ISerializationCallbackReceiver : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnBeforeSerialize(IntPtr l) {
		try {
			UnityEngine.ISerializationCallbackReceiver self=(UnityEngine.ISerializationCallbackReceiver)checkSelf(l);
			self.OnBeforeSerialize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnAfterDeserialize(IntPtr l) {
		try {
			UnityEngine.ISerializationCallbackReceiver self=(UnityEngine.ISerializationCallbackReceiver)checkSelf(l);
			self.OnAfterDeserialize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ISerializationCallbackReceiver");
		addMember(l,OnBeforeSerialize);
		addMember(l,OnAfterDeserialize);
		createTypeMetatable(l,null, typeof(UnityEngine.ISerializationCallbackReceiver));
	}
}
