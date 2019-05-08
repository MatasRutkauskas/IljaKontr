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
            richTextBox1.Text = "";
            richTextBox1.Text = "Initial data: \n";
            for (int i = 0; i < 4; i++)
            {
                Mobile mb = mobiles.GetMobile(i); 
                richTextBox1.Text += mb.name + " " + mb.model + " " + mb.price + "\n";
            }
        }

        static Mobile Cheapest(Objects mobiles) {

            double min = Double.MaxValue;
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

        static double Average(Objects mobiles) {
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += mobiles.GetMobile(i).price;
            }

            return sum / 4;
        }

        static int Number(Objects mobiles, double average) {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (mobiles.GetMobile(i).price < average) {
                    count++;
                }
            }
            return count;
        }
    }
}
