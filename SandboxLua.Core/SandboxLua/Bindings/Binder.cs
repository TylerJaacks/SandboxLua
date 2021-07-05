using NetLua;
using SandboxLua.Core.SandboxLua.Bindings.CustomBindings;
using SandboxLua.Core.SandboxLua.Bindings.Sandbox;
using System;

namespace SandboxLua.Core.SandboxLua
{
    static class Binder
    {
        public static void Bind(Lua lua)
        {
            lua.DynamicContext.print = (LuaFunction)CustomBindings.print;
            lua.DynamicContext.read = (LuaFunction)CustomBindings.read;

            MathLibrary.AddMathLibrary(lua.Context);
            IoLibrary.AddIoLibrary(lua.Context);

            // S&Box - Game Bindings

            // S&Box - Player Bindings


            lua.DynamicContext.PlaySetModel = (LuaFunction)SandboxBindings.SetModel;

            lua.DynamicContext.SetEnableAllCollisions = (LuaFunction)SandboxBindings.SetEnableAllCollisions;
            lua.DynamicContext.SetEnableDrawing = (LuaFunction)SandboxBindings.SetEnableDrawing;
            lua.DynamicContext.SetEnableHideInFirstPerson = (LuaFunction)SandboxBindings.SetEnableHideInFirstPerson;
            lua.DynamicContext.SetEnableShadowInFirstPerson = (LuaFunction)SandboxBindings.SetEnableShadowInFirstPerson;
        }
    }
}
