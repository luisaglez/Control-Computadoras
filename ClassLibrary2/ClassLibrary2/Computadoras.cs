using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClassLibrary2
{
    public partial class Computadoras : UserControl
    {
        
        public Computadoras()
        {
            InitializeComponent();
            pictureBox1.Image= Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            pictureBox2.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            pictureBox3.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            pictureBox4.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");

        }
        
        Stopwatch taimer1 = new Stopwatch();
        Stopwatch taimer2 = new Stopwatch();
        Stopwatch taimer3 = new Stopwatch();
        Stopwatch taimer4 = new Stopwatch();
        int seg, min, hrs;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "PC1 Ocupada";
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            pictureBox1.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\encendida.jpg");
            MessageBox.Show("Computadora en uso");
            timer1.Enabled= true;
            taimer1.Start();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = " PC2 Ocupada";
            button3.BackColor = Color.Red;
            button3.Enabled = false;
            pictureBox2.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\encendida.jpg");
            MessageBox.Show("Computadora en uso");
            timer2.Enabled = true;
            taimer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "PC1 Libre";
            button1.BackColor = Color.Green;
            button1.Enabled = true;
            pictureBox1.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            MessageBox.Show("Computadora en Libre");
            taimer1.Reset();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Text = "PC2 Libre";
            button3.BackColor = Color.Green;
            button3.Enabled = true;
            pictureBox2.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            MessageBox.Show("Computadora en Libre");
            taimer2.Reset();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = " PC3 Ocupada";
            button5.BackColor = Color.Red;
            button5.Enabled = false;
            pictureBox3.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\encendida.jpg");
            MessageBox.Show("Computadora en uso");
            timer3.Enabled = true;
            taimer3.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Text = "PC3 Libre";
            button5.BackColor = Color.Green;
            button5.Enabled = true;
            pictureBox3.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            MessageBox.Show("Computadora en Libre");
            taimer3.Reset();
            textBox3.Clear();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = " PC4 Ocupada";
            button7.BackColor = Color.Red;
            button7.Enabled = false;
            pictureBox4.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\encendida.jpg");
            MessageBox.Show("Computadora en uso");
            timer4.Enabled = true;
            taimer4.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Text = "PC4 Libre";
            button7.BackColor = Color.Green;
            button7.Enabled = true;
            pictureBox4.Image = Image.FromFile(@"C: \Users\Sonia\Downloads\apagada.jpg");
            MessageBox.Show("Computadora en Libre");
            taimer4.Reset();
            textBox4.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00} ", taimer1.Elapsed.Hours, taimer1.Elapsed.Minutes, taimer1.Elapsed.Seconds, taimer1.Elapsed.Milliseconds/10);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00} ", taimer2.Elapsed.Hours, taimer2.Elapsed.Minutes, taimer2.Elapsed.Seconds, taimer2.Elapsed.Milliseconds / 10);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label4.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00} ", taimer3.Elapsed.Hours, taimer3.Elapsed.Minutes, taimer3.Elapsed.Seconds, taimer3.Elapsed.Milliseconds / 10);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label5.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00} ", taimer4.Elapsed.Hours, taimer4.Elapsed.Minutes, taimer4.Elapsed.Seconds, taimer4.Elapsed.Milliseconds / 10);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            double a = taimer2.Elapsed.Seconds;
            double d = taimer2.Elapsed.Minutes;
            double b = .5;
            double c = 30;

            if (taimer2.Elapsed.Seconds <= 60)
            {
                textBox2.Text = (a * b).ToString();
            }
            if (taimer2.Elapsed.Minutes >= 1)
            {
                textBox2.Text = (d * c).ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            taimer3.Stop();
            double a = taimer3.Elapsed.Seconds;
            double d = taimer3.Elapsed.Minutes;
            double b = .5;
            double c = 30;

            if (taimer3.Elapsed.Seconds <= 60)
            {
                textBox3.Text = (a * b).ToString();
            }
            if (taimer3.Elapsed.Minutes >= 1)
            {
                textBox3.Text = (d * c).ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            taimer4.Stop();
            double a = taimer4.Elapsed.Seconds;
            double d = taimer4.Elapsed.Minutes;
            double b = .5;
            double c = 30;

            if (taimer4.Elapsed.Seconds <= 60)
            {
                textBox4.Text = (a * b).ToString();
            }
            if (taimer4.Elapsed.Minutes >= 1)
            {
                textBox4.Text = (d * c).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            taimer1.Stop();
            double a =  taimer1.Elapsed.Seconds;
            double d = taimer1.Elapsed.Minutes;
            double b = .5;
            double c = 30;

            if (taimer1.Elapsed.Seconds<=60)
            {
                textBox1.Text= (a * b).ToString();
            }
            if (taimer1.Elapsed.Minutes>= 1)
            {
                textBox1.Text = (d * c).ToString();
            }
        }

        private void Computadoras_Load(object sender, EventArgs e)
        {

        }

       
    }
}
