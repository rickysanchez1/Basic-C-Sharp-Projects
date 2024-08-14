using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino.interfaces
{
    interface IWalkAway
    {
        // Any class that inherits has to implement this method and has to take in that parameter and has to return void
        void WalkAway(Player player);
    }
}
