using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2
{
    class Objects
    {
        Mobile[] mb;

        public Objects()//constructor
        {
            mb = new Mobile[4];//initializes array
            mb[0] = new Mobile("samsung", "s10", 500.20);
            mb[1] = new Mobile("iphone", "x", 670.21);
            mb[2] = new Mobile("huawei", "p10", 800.54);
            mb[3] = new Mobile("google", "pixel", 1200.20);
        }

        public Mobile GetMobile(int i) {//returns a mobile from the array
            return mb[i];
        }
    }
}
