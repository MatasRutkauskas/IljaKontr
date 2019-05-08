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
                richTextBox1.Text += mb.name + " " + mb.model + " Price: " + mb.price + "\n";
            }

            richTextBox1.Text += "\n";

            Mobile cheapestMobile = Cheapest(mobiles);
            richTextBox1.Text += "Cheapest mobile: " + cheapestMobile.name + "\n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Average price: " + Average(mobiles) + "\n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Number of mobiles cheaper than average price: " + Number(mobiles, Average(mobiles)) + "\n";
        }

        static Mobile Cheapest(Objects mobiles) {//returns the mobile with the cheapest price

            double min = Double.MaxValue;//value to compare to
            Mobile cheapest = new Mobile();//found cheapest mobile

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

        static double Average(Objects mobiles) {//returns the average price
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += mobiles.GetMobile(i).price;
            }

            return sum / 4;
        }

        static int Number(Objects mobiles, double average) {//counts the number of mobiles cheaper than the average price
            int count = 0;//number of mobiles
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
