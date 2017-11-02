using UnityEngine;
using System.Collections;
using SLua;
using UnityEngine.UI;

public class MainFun : MonoBehaviour
{
    private LuaSvr lua_svr;
    private LuaTable self;
    private LuaFunction update;

    [CustomLuaClass]
    public delegate void UpdateDelegate(object self);

    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int init(System.IntPtr L)
    {
        //设置初始化LuaObject对象
        LuaObject.init(L);
        return 0;
    }

    //Button btt;

    //UpdateDelegate ud;

	// Use this for initialization
	void Start() 
    {
        lua_svr = new LuaSvr();

        lua_svr.init(null, complete, LuaSvrFlag.LSF_BASIC | LuaSvrFlag.LSF_EXTLIB);
        //btt.onClick.AddListener(delegate() { });
	}

    private void complete()
    {
        lua_svr.start("main");
    }
    void Update()
    {
        //if (ud != null) ud(self);
    }
}
