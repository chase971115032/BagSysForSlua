using System;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Component : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Component o;
			o=new UnityEngine.Component();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				var ret=self.GetComponent<UnityEngine.Component>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetComponent to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				var ret=self.GetComponentInChildren<UnityEngine.Component>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetComponentInChildren to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentsInChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				var ret=self.GetComponentsInChildren<UnityEngine.Component>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(List<UnityEngine.Component>))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Component> a1;
				checkType(l,2,out a1);
				self.GetComponentsInChildren<UnityEngine.Component>(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(bool))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInChildren<UnityEngine.Component>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type),typeof(bool))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentsInChildren(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(bool),typeof(List<UnityEngine.Component>))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Collections.Generic.List<UnityEngine.Component> a2;
				checkType(l,3,out a2);
				self.GetComponentsInChildren<UnityEngine.Component>(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetComponentsInChildren to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInParent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				var ret=self.GetComponentInParent<UnityEngine.Component>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentInParent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetComponentInParent to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentsInParent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				var ret=self.GetComponentsInParent<UnityEngine.Component>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(bool))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInParent<UnityEngine.Component>(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInParent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentsInParent(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetComponentsInParent to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponents(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				var ret=self.GetComponents<UnityEngine.Component>();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(List<UnityEngine.Component>))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Component> a1;
				checkType(l,2,out a1);
				self.GetComponents<UnityEngine.Component>(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponents(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Collections.Generic.List<UnityEngine.Component> a2;
				checkType(l,3,out a2);
				self.GetComponents(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function GetComponents to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareTag(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CompareTag(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessageUpwards(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessageUpwards(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SendMessageUpwards to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessage(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessage(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SendMessage to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BroadcastMessage(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.BroadcastMessage(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function BroadcastMessage to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.transform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rigidbody);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody2D(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rigidbody2D);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_camera(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.camera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_light(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.light);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animation(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.animation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constantForce(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.constantForce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderer(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audio(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiText(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.guiText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_guiTexture(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.guiTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider2D(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collider2D);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hingeJoint(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hingeJoint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleEmitter(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.particleEmitter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleSystem(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.particleSystem);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tag(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tag(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.tag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Component");
		addMember(l,GetComponent);
		addMember(l,GetComponentInChildren);
		addMember(l,GetComponentsInChildren);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponentsInParent);
		addMember(l,GetComponents);
		addMember(l,CompareTag);
		addMember(l,SendMessageUpwards);
		addMember(l,SendMessage);
		addMember(l,BroadcastMessage);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"rigidbody",get_rigidbody,null,true);
		addMember(l,"rigidbody2D",get_rigidbody2D,null,true);
		addMember(l,"camera",get_camera,null,true);
		addMember(l,"light",get_light,null,true);
		addMember(l,"animation",get_animation,null,true);
		addMember(l,"constantForce",get_constantForce,null,true);
		addMember(l,"renderer",get_renderer,null,true);
		addMember(l,"audio",get_audio,null,true);
		addMember(l,"guiText",get_guiText,null,true);
		addMember(l,"guiTexture",get_guiTexture,null,true);
		addMember(l,"collider",get_collider,null,true);
		addMember(l,"collider2D",get_collider2D,null,true);
		addMember(l,"hingeJoint",get_hingeJoint,null,true);
		addMember(l,"particleEmitter",get_particleEmitter,null,true);
		addMember(l,"particleSystem",get_particleSystem,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"tag",get_tag,set_tag,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Component),typeof(UnityEngine.Object));
	}
}
