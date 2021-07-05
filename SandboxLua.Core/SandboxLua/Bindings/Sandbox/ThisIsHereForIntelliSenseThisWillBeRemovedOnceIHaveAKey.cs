using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class ThisIsHereForIntelliSenseThisWillBeRemovedOnceIHaveAKey
    {

    }

    public class Game
    {

    }

    public class Client
    {

    }

    public class Player
    {
        public Func<bool> EnableAllCollisions { get; internal set; }
        public Func<bool> EnableHideInFirstPerson { get; internal set; }
        public Func<bool> EnableDrawing { get; internal set; }
        public Func<bool> EnableShadowInFirstPerson { get; internal set; }

        internal void SetModel()
        {
            throw new NotImplementedException();
        }
    }
}
