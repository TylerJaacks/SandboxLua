using Sandbox;
using NetLua;

using SandboxLua.Core.SandboxLua.Utils;

namespace SandboxLua.Core.SandboxLua.Bindings.Sandbox
{
    class SandboxBindings
    {
        // TODO: Not sure what the fuck to do.
        public static LuaArguments CreatePlayer(LuaArguments args)
        {
            Player player = new Player();

            return new LuaArguments();
        }

        // TODO: This will need to reference the the actual player class.
        public static LuaArguments SetModel(LuaArguments args)
        {
            Player player = PlayerUtils.GetPlayerFromName(args[0].ToString());

            player.SetModel();

            return Lua.Return();
        }

        public static LuaArguments SetEnableAllCollisions(LuaArguments args)
        {
            Player player = PlayerUtils.GetPlayerFromName(args[0].ToString());

            player.EnableAllCollisions = args[0].AsBool;

            return Lua.Return();
        }

        public static LuaArguments SetEnableDrawing(LuaArguments args)
        {
            Player player = PlayerUtils.GetPlayerFromName(args[0].ToString());

            player.EnableDrawing = args[0].AsBool;

            return Lua.Return();
        }

        public static LuaArguments SetEnableHideInFirstPerson(LuaArguments args)
        {
            Player player = PlayerUtils.GetPlayerFromName(args[0].ToString());

            player.EnableHideInFirstPerson = args[0].AsBool;

            return Lua.Return();
        }

        public static LuaArguments SetEnableShadowInFirstPerson(LuaArguments args)
        {
            Player player = PlayerUtils.GetPlayerFromName(args[0].ToString());

            player.EnableShadowInFirstPerson = args[0].AsBool;

            return Lua.Return();
        }
    }
}
