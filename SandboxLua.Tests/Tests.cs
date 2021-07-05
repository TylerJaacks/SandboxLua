using Microsoft.VisualStudio.TestTools.UnitTesting;

using SandboxLua.Core;

namespace SandboxLua.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            string[] files =
            {
                "C:\\Users\\Tyler Jaacks\\Documents\\Visual Studio 2022\\Projects\\SandboxLua\\SandboxLua.Tests\\game.lua",
                "C:\\Users\\Tyler Jaacks\\Documents\\Visual Studio 2022\\Projects\\SandboxLua\\SandboxLua.Tests\\game2.lua"
            };

            SandboxLuaCore sandboxLuaCore = new();

            sandboxLuaCore.RunLuaFiles(files);
        }
    }
}
