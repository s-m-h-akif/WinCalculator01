using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wincalci01;

namespace WinCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(firstnum_textBox.Text);
            int num2 = Convert.ToInt32(SecNum_textBox.Text);
           SimpleCalci sc = new SimpleCalci();
            Res_textBox.Text = sc.add(num1, num2);
           

        }

        private void sub_button_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(firstnum_textBox.Text);
            int num2 = Convert.ToInt32(SecNum_textBox.Text);
            SimpleCalci sc = new SimpleCalci();
            Res_textBox.Text = sc.sub(num1, num2);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
