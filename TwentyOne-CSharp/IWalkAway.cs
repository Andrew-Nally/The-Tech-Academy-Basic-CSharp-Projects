using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//can only inherit one base class, but inherit as many interface classes as you want
namespace TwentyOne_CSharp
    //everything is public in an interface class
{
    interface IWalkAway
    {
       void WalkAway(Player player);

    }
}
