using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincalci01
{
    public class SimpleCalci
    {

        public string add(int a , int b)
        {
            int res = a + b;
            return "The result is" + res;
        }
        public string sub(int a, int b)
        {
            int res = a - b;
            return "The result is" + res;
        }
        public string mul(int a, int b)
        {
            int res = a * b;
            return "The result is" + res;
        }
        public string div(int a, int b)
        {
            int res = a / b;
            return "The result is" + res;
        }


    }
}
