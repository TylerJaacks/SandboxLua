using NetLua;
using SandboxLua.Core.SandboxLua;
using System;
using System.IO;

namespace SandboxLua.Core
{
    public class SandboxLuaCore
    {
        public Lua lua { get; set; }

        public SandboxLuaCore()
        {
            lua = new Lua();

            Binder.Bind(lua);
        }

        private string ConcatenateFilesToString(string[] srcFileNames)
        {
            string finalString = "";

            foreach (string file in srcFileNames)
            {
                string text = System.IO.File.ReadAllText(file);

                finalString += text;
            }

            return finalString;
        }

        public void RunLuaFiles(string[] files)
        {
            string luaCode = ConcatenateFilesToString(files);

            string[] luaLines = luaCode.Split("\n");

            foreach (string line in luaLines)
            {
                LuaObject luaObject = lua.DoString(line)[0];

                Console.WriteLine("Ran Line");
            }
        }
    }
}
