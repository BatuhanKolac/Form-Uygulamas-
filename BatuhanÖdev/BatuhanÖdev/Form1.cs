using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatuhanÖdev
{
    public partial class Form1 : Form
    {
        int id;
        public Form1()
        {
            InitializeComponent();
            DateTime bugün = DateTime.Now;
            textBox9.Text = Convert.ToString(bugün);
            Random Rastgele = new Random();
            this.id = Rastgele.Next(0, 1);
           

        }
        private void Form1_Activated(object sender, System.EventArgs e)
        {
           

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X, sayiY;
            sayiY = 01;
            X = Convert.ToInt32(textBox1.Text);
            double islem = 0;
            double logaritma = 0;
            double logaritma1, logaritma2;
            double taban = 2;
            islem = ((Math.Pow(X, 3) + (2*(Math.Pow(X, 2)) + sayiY)));
            logaritma1 = Math.Log(islem);
            logaritma2 =Math.Log(2);
            logaritma = logaritma1 / logaritma2;
            textBox5.Text = Convert.ToString(logaritma);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(textBox1.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string metin1 = Convert.ToString(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin1;
            metin1 = Convert.ToString(textBox2.Text);
            textBox6.Text = Convert.ToString(metin1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string metin2 = Convert.ToString(textBox3.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin2 = Convert.ToString(textBox3.Text);
            string Metin2 = string.Copy(metin2);
            textBox7.Text = Metin2.ToLower();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin3 = Convert.ToString(textBox4.Text);
            textBox8.Text = metin3.ToUpper();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 2000;
            Random r = new Random();
            label3.Text = r.Next(0, 10).ToString();
            label4.Text = r.Next(0, 10).ToString();
            label5.Text = r.Next(0, 10).ToString();
            label6.Text = r.Next(0, 10).ToString();
            label7.Text = r.Next(0, 10).ToString();
            label8.Text = r.Next(0, 10).ToString();
            label9.Text = r.Next(0, 10).ToString();
            label10.Text = r.Next(0, 10).ToString();
            label11.Text = r.Next(0, 10).ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            label3.Text = r.Next(0, 10).ToString();
            label4.Text = r.Next(0, 10).ToString();
            label5.Text = r.Next(0, 10).ToString();
            label6.Text = r.Next(0, 10).ToString();
            label7.Text = r.Next(0, 10).ToString();
            label8.Text = r.Next(0, 10).ToString();
            label9.Text = r.Next(0, 10).ToString();
            label10.Text = r.Next(0, 10).ToString();
            label11.Text = r.Next(0, 10).ToString();
        }
    }
}
