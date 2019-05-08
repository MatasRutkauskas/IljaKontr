using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm2
{
    public partial class Form1 : Form
    {
        Objects mobiles = new Objects();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        static Mobile Cheapest(Objects mobiles) {

            double min = 9999;
            Mobile cheapest = new Mobile();

            for (int i = 0; i < 4; i++)
            {
                Mobile mb = mobiles.GetMobile(i);
                if (mb.price < min) {
                    min = mb.price;
                    cheapest = new Mobile(mb.name, mb.model, mb.price);
                }
            }

            return cheapest;
        }
    }
}
