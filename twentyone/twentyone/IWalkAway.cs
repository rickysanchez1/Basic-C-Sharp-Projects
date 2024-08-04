using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    interface IWalkAway
    {
        // Any class that inherits has to implement this method and has to take in that parameter and has to return void
        void WalkAway(Player player);
    }
}
