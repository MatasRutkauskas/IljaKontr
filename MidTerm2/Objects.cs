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

        public Objects()
        {
            mb = new Mobile[4];
            mb[0] = new Mobile("samsung", "s10", 500.20);
            mb[1] = new Mobile("iphone", "x", 500.20);
            mb[2] = new Mobile("huawei", "p10", 500.20);
            mb[3] = new Mobile("google", "pixel", 500.20);
        }

        public Mobile GetMobile(int i) {
            return mb[i];
        }
    }
}
