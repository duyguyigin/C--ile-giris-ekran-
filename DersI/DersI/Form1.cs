using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersI
{
    public partial class Form1 : Form
    {
        bool secilideger = false;
        int sayi1, sayi2, sonuc;
        string secilenislem;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (secilideger == false)
            {
                textBox1.Text += 1;
            }
            else
            {
                textBox2.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 2;
            }
            else
            {
                textBox2.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 3;
            }
            else
            {
                textBox2.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 4;
            }
            else
            {
                textBox2.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 5;
            }
            else
            {
                textBox2.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 6;
            }
            else
            {
                textBox2.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 7;
            }
            else
            {
                textBox2.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 8;
            }
            else
            {
                textBox2.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (secilideger == false)
            {
                textBox1.Text += 9;
            }
            else
            {
                textBox2.Text += 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
          

            if (secilideger == false)
            {
                if (textBox1.Text != "")
                { textBox1.Text += 0; }
            }
            else
            {
                if (textBox2.Text != "")
                { textBox2.Text += 0; }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            secilideger = true;
            secilenislem = "toplama";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            secilideger = true;
            secilenislem = "çıkarma";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            secilideger = true;
            secilenislem = "çarpma";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            secilideger = true;
            secilenislem = "bölme";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("2 sayı giriniz");
            }
            else
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);

                if (secilenislem == "toplama")
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (secilenislem == "çıkarma")
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (secilenislem == "çarpma")
                {
                    sonuc = sayi1 * sayi2;
                }
                else if (secilenislem == "bölme")
                {
                    sonuc = sayi1 / sayi2;
                }

                MessageBox.Show("Sonuç = " + sonuc.ToString());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox2.Clear();

            secilideger = false;
    

        }
    }
}
