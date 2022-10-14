using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we declare variables
            double num1, num2, addition, subtraction, multiplication, division, power, root;

            //we convert the input data to double
            //and create new variables
            num1 = Convert.ToDouble(n1.Text);
            num2 = Convert.ToDouble(n2.Text);

            //creation of operations
            addition = num1 + num2;
            subtraction = num1 - num2;
            multiplication = num1 * num2;
            division = num1 / num2;
            power = Math.Pow(num1, num2);
            root = Math.Pow(num1, (1/num2));

            //we convert the double to string
            textaddition.Text = Convert.ToString(addition);
            textsubtract.Text = Convert.ToString(subtraction);
            textmulti.Text = Convert.ToString(multiplication);
            textdivision.Text = Convert.ToString(division);
            textpower.Text = Convert.ToString(power);
            textroot.Text = Convert.ToString(root);
            n1.Text = Convert.ToString(num1);
            n2.Text = Convert.ToString(num2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textaddition.Clear();
            textsubtract.Clear();
            textmulti.Clear();
            textdivision.Clear();
            textpower.Clear();
            textroot.Clear();
            n1.Clear();
            n2.Clear();
        }
    }
}
