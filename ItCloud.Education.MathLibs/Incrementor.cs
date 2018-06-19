using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCloud.Education.MathLibs
{
    public static class Incrementor
    {
        public static int Inc(ref int val)
        {
            ++val;
            return 1;
        }

        public static int Intout(out int val1, out string str)
        {
            val1 = 1;
            str = "something";
            return 0;
        }
    }  

}
