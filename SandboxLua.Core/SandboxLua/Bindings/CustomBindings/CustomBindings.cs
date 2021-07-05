using NetLua;

using System;

namespace SandboxLua.Core.SandboxLua.Bindings.CustomBindings
{
    class CustomBindings
    {
        public static LuaArguments print(LuaArguments args)
        {
            Console.WriteLine(String.Join("\t", Array.ConvertAll<LuaObject, string>(args, x => x.ToString())));
            return Lua.Return();
        }

        public static LuaArguments io_write(LuaArguments args)
        {
            Console.Write(args[0].ToString());
            return Lua.Return();
        }

        public static LuaArguments read(LuaArguments args)
        {
            return Lua.Return(Console.ReadLine());
        }
    }
}
