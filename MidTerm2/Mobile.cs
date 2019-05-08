using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2
{
    class Mobile
    {
        public string name { get; set; }
        public string model { get; set; }
        public double price { get; set; }

        public Mobile() {
            name = "";
            model = "";
            price = 0;
        }

        public Mobile(string name, string model, double price) {
            this.name = name;
            this.model = model;
            this.price = price;
        }
    }
}
