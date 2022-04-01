using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double val1 = 0, val2 = 0;
        string ope = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                val2 = Convert.ToDouble(result.Text, CultureInfo.InvariantCulture);

                if (ope == "soma")
                {
                    result.Text = Convert.ToString(val1 + val2);
                    op.Text = "";
                    ope = "";
                }

                else if (ope == "sub")
                {
                    result.Text = Convert.ToString(val1 - val2);
                    op.Text = "";
                    ope = "";
                }

                else if (ope == "mult")
                {
                    result.Text = Convert.ToString(val1 * val2);
                    op.Text = "";
                    ope = "";
                }

                else if (ope == "div")
                {
                    result.Text = Convert.ToString(val1 / val2);
                    op.Text = "";
                    ope = "";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                val1 = Convert.ToDouble(result.Text, CultureInfo.InvariantCulture);

                result.Text = "";
                ope = "sub";
                op.Text = "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                val1 = Convert.ToDouble(result.Text, CultureInfo.InvariantCulture);

                result.Text = "";
                ope = "mult";
                op.Text = "x";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                val1 = Convert.ToDouble(result.Text, CultureInfo.InvariantCulture);

                result.Text = "";
                ope = "div";
                op.Text = "÷";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "";
            op.Text = "";
            val1 = 0;
            val2 = 0;
            ope = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                val1 = Convert.ToDouble(result.Text, CultureInfo.InvariantCulture);

                result.Text = "";
                ope = "soma";
                op.Text = "+";
            }
        }
    }
}
