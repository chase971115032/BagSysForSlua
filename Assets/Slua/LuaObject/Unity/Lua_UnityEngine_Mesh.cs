﻿using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Mesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Mesh o;
			o=new UnityEngine.Mesh();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				self.Clear();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Clear(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Clear to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RecalculateBounds(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateBounds();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RecalculateNormals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateNormals();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Optimize(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.Optimize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTriangles(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTriangles(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTriangles(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetTriangles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIndices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetIndices(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIndices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetIndices(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTopology(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTopology(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CombineMeshes(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				UnityEngine.CombineInstance[] a1;
				checkArray(l,2,out a1);
				self.CombineMeshes(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				UnityEngine.CombineInstance[] a1;
				checkArray(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.CombineMeshes(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
				UnityEngine.CombineInstance[] a1;
				checkArray(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.CombineMeshes(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function CombineMeshes to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkDynamic(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.MarkDynamic();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UploadMeshData(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.UploadMeshData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBlendShapeName(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBlendShapeName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBlendShapeIndex(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetBlendShapeIndex(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isReadable(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isReadable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
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
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.vertices=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.normals);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.normals=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tangents);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector4[] v;
			checkArray(l,2,out v);
			self.tangents=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv2(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv2(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv1(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv1(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv1=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounds(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Bounds v;
			checkValueType(l,2,out v);
			self.bounds=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Color[] v;
			checkArray(l,2,out v);
			self.colors=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colors32);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Color32[] v;
			checkArray(l,2,out v);
			self.colors32=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangles(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.triangles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_triangles(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] v;
			checkArray(l,2,out v);
			self.triangles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertexCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_subMeshCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.subMeshCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_subMeshCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.subMeshCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneWeights(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.boneWeights);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneWeights(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.BoneWeight[] v;
			checkArray(l,2,out v);
			self.boneWeights=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bindposes(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bindposes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bindposes(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Matrix4x4[] v;
			checkArray(l,2,out v);
			self.bindposes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendShapeCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.blendShapeCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Mesh");
		addMember(l,Clear);
		addMember(l,RecalculateBounds);
		addMember(l,RecalculateNormals);
		addMember(l,Optimize);
		addMember(l,GetTriangles);
		addMember(l,SetTriangles);
		addMember(l,GetIndices);
		addMember(l,SetIndices);
		addMember(l,GetTopology);
		addMember(l,CombineMeshes);
		addMember(l,MarkDynamic);
		addMember(l,UploadMeshData);
		addMember(l,GetBlendShapeName);
		addMember(l,GetBlendShapeIndex);
		addMember(l,"isReadable",get_isReadable,null,true);
		addMember(l,"vertices",get_vertices,set_vertices,true);
		addMember(l,"normals",get_normals,set_normals,true);
		addMember(l,"tangents",get_tangents,set_tangents,true);
		addMember(l,"uv",get_uv,set_uv,true);
		addMember(l,"uv2",get_uv2,set_uv2,true);
		addMember(l,"uv1",get_uv1,set_uv1,true);
		addMember(l,"bounds",get_bounds,set_bounds,true);
		addMember(l,"colors",get_colors,set_colors,true);
		addMember(l,"colors32",get_colors32,set_colors32,true);
		addMember(l,"triangles",get_triangles,set_triangles,true);
		addMember(l,"vertexCount",get_vertexCount,null,true);
		addMember(l,"subMeshCount",get_subMeshCount,set_subMeshCount,true);
		addMember(l,"boneWeights",get_boneWeights,set_boneWeights,true);
		addMember(l,"bindposes",get_bindposes,set_bindposes,true);
		addMember(l,"blendShapeCount",get_blendShapeCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Mesh),typeof(UnityEngine.Object));
	}
}
