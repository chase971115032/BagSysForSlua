using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshTriangulation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation o;
			o=new UnityEngine.NavMeshTriangulation();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.vertices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.vertices=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.indices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_indices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkValueType(l,1,out self);
			System.Int32[] v;
			checkArray(l,2,out v);
			self.indices=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layers(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.layers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layers(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkValueType(l,1,out self);
			System.Int32[] v;
			checkArray(l,2,out v);
			self.layers=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshTriangulation");
		addMember(l,"vertices",get_vertices,set_vertices,true);
		addMember(l,"indices",get_indices,set_indices,true);
		addMember(l,"layers",get_layers,set_layers,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshTriangulation),typeof(System.ValueType));
	}
}
