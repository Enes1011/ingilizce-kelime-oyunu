using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_kelime_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
            button6.Enabled = false;
            button6.Visible = false;
            button7.Enabled = false;
            button7.Visible = false;
            button8.Enabled = false;
            button8.Visible = false;
            button9.Enabled = false;
            button9.Visible = false;
            button10.Enabled = false;
            button10.Visible = false;


        }
            private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            puan -= 10;
            label4.Text = puan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "sleep";
            label3.Text = "uyku";
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = true;
            button4.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "sleep";
            label3.Text = "uyku";
            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = true;
            button4.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "world";
            label3.Text = "dünya";
            button6.Enabled = false;
            button6.Visible = false;
            button7.Enabled = true;
            button7.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "word";
            label3.Text = "kelime";
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button6.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "lemon";
            label3.Text = "limon";
            button5.Enabled = false;
            button5.Visible = false;
            button6.Enabled = true;
            button6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "long";
            label3.Text = "uzun";
            button7.Enabled = false;
            button7.Visible = false;
            button8.Enabled = true;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            label1.Text = "city";
            label3.Text = "şehir";
            button8.Enabled = false;
            button8.Visible = false;
            button9.Enabled = true;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "execute";
            label3.Text = "uygulamak";
            button9.Enabled = false;
            button9.Visible = false;
            button10.Enabled = true;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            button11.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "street";
            label3.Text = "cadde";
            button10.Enabled = false;
            button10.Visible = false;
            button11.Enabled = true;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            button12.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "speacial";
            label3.Text = "genel";
            button11.Enabled = false;
            button11.Visible = false;
            button12.Enabled = true;
            button12.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            button1.Visible = true;
            button2.Visible = true;
            label1.Text = "salt";
            label3.Text = "çorba";
            button12.Enabled = false;
            button12.Visible = false;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puan += 10;
            label4.Text = puan.ToString();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }
    }
}
