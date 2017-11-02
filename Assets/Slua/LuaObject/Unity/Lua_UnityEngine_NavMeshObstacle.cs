using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshObstacle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.radius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.radius=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.velocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_carving(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.carving);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_carving(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.carving=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_carvingMoveThreshold(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.carvingMoveThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_carvingMoveThreshold(IntPtr l) {
		try {
			UnityEngine.NavMeshObstacle self=(UnityEngine.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.carvingMoveThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshObstacle");
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"carving",get_carving,set_carving,true);
		addMember(l,"carvingMoveThreshold",get_carvingMoveThreshold,set_carvingMoveThreshold,true);
		createTypeMetatable(l,null, typeof(UnityEngine.NavMeshObstacle),typeof(UnityEngine.Behaviour));
	}
}
