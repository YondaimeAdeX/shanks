using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shanks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;
            label3.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 - s2;
            label3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 * s2;
            label3.Text = sonuc.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc = 0;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            sonuc = s1 / s2;
            label3.Text = sonuc.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 = Convert.ToInt32(textBox4.Text);
            s2 = Convert.ToInt32(textBox3.Text);
            sonuc = (s1 + s2) * 2 - 5;
            label4.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int uk, kk, hesap;
            uk = Convert.ToInt32(textBox6.Text);
            kk = Convert.ToInt32(textBox5.Text);
            hesap = uk * kk;
            label7.Text = "Alanı "+hesap.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int uk, kk, hesap;
            uk = Convert.ToInt32(textBox6.Text);
            kk = Convert.ToInt32(textBox5.Text);
            hesap = uk+uk+kk+kk;
            label7.Text = "Çevresi "+hesap.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int dogumYili, yas, yil;
            yil = DateTime.Now.Year;
            dogumYili = Convert.ToInt32(textBox8.Text);
            yas = yil - dogumYili;
            label10.Text = yas.ToString() + " Yaşındasınız.";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            double f, s;
            f = Convert.ToDouble(textBox7.Text);
            s = f - (f * 10 / 100);
            label13.Text = s.ToString("c");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double f, s;
            f = Convert.ToDouble(textBox7.Text);
            s = f - (f * 25 / 100);
            label13.Text = s.ToString("c");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double f, s;
            f = Convert.ToDouble(textBox7.Text);
            s = f - (f * 50 / 100);
            label13.Text = s.ToString("c");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double f, s;
            f = Convert.ToDouble(textBox7.Text);
            s = f - (f * 75 / 100);
            label13.Text = s.ToString("c");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double tu, y, sonuc;
            tu = Convert.ToDouble(textBox10.Text);
            y = Convert.ToDouble(textBox9.Text);
            sonuc = (tu * y) / 2;
            label14.Text = "Alanı " + sonuc.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double yc, alan;
            yc = Convert.ToDouble(textBox12.Text);
            alan=Math.PI * (yc * yc);
            label17.Text = "Alanı " + alan.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double yc, cevre;
            yc = Convert.ToDouble(textBox12.Text);
            cevre = 2*Math.PI * yc;
            label17.Text = "Çevresi " + cevre.ToString();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4,s5, s6, toplamı;
            s1 = Convert.ToInt32(textBox13.Text);
            s2 = Convert.ToInt32(textBox11.Text);
            s3 = Convert.ToInt32(textBox15.Text);
            s4 = Convert.ToInt32(textBox14.Text);
            s5 = Convert.ToInt32(textBox17.Text);
            s6 = Convert.ToInt32(textBox16.Text);
            toplamı = s1 + s2 + s3 + s4 + s5 + s6;
            label18.Text = toplamı.ToString();
        }
    }
}
