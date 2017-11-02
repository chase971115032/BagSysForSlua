using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Cloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bendingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bendingStiffness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bendingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.bendingStiffness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stretchingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stretchingStiffness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stretchingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.stretchingStiffness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damping(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.damping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damping(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.damping=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thickness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.thickness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thickness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.thickness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_externalAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.externalAcceleration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_externalAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.externalAcceleration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_randomAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.randomAcceleration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_randomAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.randomAcceleration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGravity(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useGravity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGravity(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useGravity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selfCollision(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selfCollision);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selfCollision(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.selfCollision=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normals(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.normals);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Cloth");
		addMember(l,"bendingStiffness",get_bendingStiffness,set_bendingStiffness,true);
		addMember(l,"stretchingStiffness",get_stretchingStiffness,set_stretchingStiffness,true);
		addMember(l,"damping",get_damping,set_damping,true);
		addMember(l,"thickness",get_thickness,set_thickness,true);
		addMember(l,"externalAcceleration",get_externalAcceleration,set_externalAcceleration,true);
		addMember(l,"randomAcceleration",get_randomAcceleration,set_randomAcceleration,true);
		addMember(l,"useGravity",get_useGravity,set_useGravity,true);
		addMember(l,"selfCollision",get_selfCollision,set_selfCollision,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"vertices",get_vertices,null,true);
		addMember(l,"normals",get_normals,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Cloth),typeof(UnityEngine.Component));
	}
}
