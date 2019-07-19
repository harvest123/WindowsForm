using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void btn1_Click(object sender, EventArgs e)
        {
            string input = tbox1.Text;
            Regex regex = new Regex("^[0-9a-f[A-F]{6}$");
            if (regex.IsMatch(input))
            {
                long[] number = new long[3];
                for (int i = 0; i < 3; i++)
                {
                    string str = input.Substring(i * 2, 2);
                    number[i] = Convert.ToInt32(str, 16);
                }
                number[0] >>= 3;
                number[1] >>= 2;
                number[2] >>= 3;
                long output = number[2];
                output += number[1] << 5;
                output += number[0] << 11;
                tbox2.Text = "";
                tbox2.Text += string.Format("{0:X}", output);

                //tbox2.Text = "num" + number[0];


            }
            else
            {
                MessageBox.Show("输入格式不正确", "ERROR");
            }
        }
    }
}
