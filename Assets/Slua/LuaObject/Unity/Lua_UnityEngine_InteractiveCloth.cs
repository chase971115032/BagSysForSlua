using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_InteractiveCloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddForceAtPosition(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddForceAtPosition(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddForceAtPosition(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function AddForceAtPosition to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AttachToCollider(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
				UnityEngine.Collider a1;
				checkType(l,2,out a1);
				self.AttachToCollider(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
				UnityEngine.Collider a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.AttachToCollider(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
				UnityEngine.Collider a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				self.AttachToCollider(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function AttachToCollider to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DetachFromCollider(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			UnityEngine.Collider a1;
			checkType(l,2,out a1);
			self.DetachFromCollider(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mesh);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.mesh=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_friction(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.friction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_friction(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.friction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_density(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.density);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_density(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.density=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressure(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pressure);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressure(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.pressure=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionResponse(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collisionResponse);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionResponse(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.collisionResponse=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tearFactor(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tearFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tearFactor(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.tearFactor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachmentTearFactor(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.attachmentTearFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_attachmentTearFactor(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.attachmentTearFactor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachmentResponse(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.attachmentResponse);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_attachmentResponse(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.attachmentResponse=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTeared(IntPtr l) {
		try {
			UnityEngine.InteractiveCloth self=(UnityEngine.InteractiveCloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isTeared);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.InteractiveCloth");
		addMember(l,AddForceAtPosition);
		addMember(l,AttachToCollider);
		addMember(l,DetachFromCollider);
		addMember(l,"mesh",get_mesh,set_mesh,true);
		addMember(l,"friction",get_friction,set_friction,true);
		addMember(l,"density",get_density,set_density,true);
		addMember(l,"pressure",get_pressure,set_pressure,true);
		addMember(l,"collisionResponse",get_collisionResponse,set_collisionResponse,true);
		addMember(l,"tearFactor",get_tearFactor,set_tearFactor,true);
		addMember(l,"attachmentTearFactor",get_attachmentTearFactor,set_attachmentTearFactor,true);
		addMember(l,"attachmentResponse",get_attachmentResponse,set_attachmentResponse,true);
		addMember(l,"isTeared",get_isTeared,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.InteractiveCloth),typeof(UnityEngine.Cloth));
	}
}
