using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 1)
                textBox3.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
                textBox4.Focus();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 2)
                textBox5.Focus();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;

            char[] para = a.ToCharArray();

            int sum=0;
            int result;
            int item=0;
            for (int i = 0; i < para.Length; i++)
            {
                
                {   int number=Convert.ToInt16 (para[i].ToString());
                
                if (i % 2 == 0)
                {
                    item = 2 * number;

                }
                else
                { item = number; }
                
               
                    if (item < 10)
                        sum = sum + item;
                    else
                    {
                        int a1, a2;
                        a1 = Convert.ToInt16(item.ToString()[0].ToString());
                        a2 = Convert.ToInt16(item.ToString()[1].ToString());
                        
                        sum = sum + a1 + a2;
                    }

                }
                
            }

            
            result = 10 - sum % 10;
            if (result == 10)
                result = 0;
            textBox6.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text + " " + textBox2.Text + " "+textBox3.Text+" "+textBox4.Text+" "+textBox5.Text+" "+textBox6.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
