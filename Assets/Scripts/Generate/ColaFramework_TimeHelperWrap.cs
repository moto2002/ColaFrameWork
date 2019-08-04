﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ColaFramework_TimeHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("TimeHelper");
		L.RegFunction("SetTimer", SetTimer);
		L.RegFunction("SetRepeatTimer", SetRepeatTimer);
		L.RegFunction("KillTimer", KillTimer);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				int o = ColaFramework.TimeHelper.SetTimer(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				int o = ColaFramework.TimeHelper.SetTimer(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ColaFramework.TimeHelper.SetTimer");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRepeatTimer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				int o = ColaFramework.TimeHelper.SetRepeatTimer(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				int o = ColaFramework.TimeHelper.SetRepeatTimer(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ColaFramework.TimeHelper.SetRepeatTimer");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int KillTimer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			ColaFramework.TimeHelper.KillTimer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
