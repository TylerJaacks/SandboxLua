using NetLua;
using SandboxLua.Core.SandboxLua.Bindings.CustomBindings;
using System;

namespace SandboxLua.Core.SandboxLua
{
    static class Binder
    {
        public static void Bind(Lua lua)
        {
            lua.DynamicContext.print = (LuaFunction) CustomBindings.print;
            lua.DynamicContext.read = (LuaFunction) CustomBindings.read;

            MathLibrary.AddMathLibrary(lua.Context);
            IoLibrary.AddIoLibrary(lua.Context);
        }
    }
}
