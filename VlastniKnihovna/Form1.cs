using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlastni;

namespace VlastniKnihovna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<double> cisla = new List<double>();
            double x;
            foreach (string i in textBox1.Lines)
            {
                x = double.Parse(i);
                cisla.Add(x);
            }

            MessageBox.Show("Druhé maximum je " + Najdi.DruheMax(cisla) + "\nDruhé minimum je " + Najdi.DruheMin(cisla));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<char> znaky = textBox2.Text.ToList();

            MessageBox.Show("Znak v největším počtu je " + Najdi.znakvNejvetsimPoctu(znaky));
        }
    }
            
}
