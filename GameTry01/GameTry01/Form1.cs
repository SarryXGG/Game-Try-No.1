using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTry01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int pocet = 0;
        int pokusy = 0;
        DateTime dt;
        TimeSpan konecnyCas = TimeSpan.MaxValue;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Generuje barvu na zelenou
        /// </summary>
        private void Generace()
        {
            int number = random.Next(1, 16);
            switch (number)
            {
                case 1:
                    button1.BackColor = Color.Green;
                    break;
                case 2:
                    button2.BackColor = Color.Green;
                    break;
                case 3:
                    button3.BackColor = Color.Green;
                    break;
                case 4:
                    button4.BackColor = Color.Green;
                    break;
                case 5:
                    button5.BackColor = Color.Green;
                    break;
                case 6:
                    button6.BackColor = Color.Green;
                    break;
                case 7:
                    button7.BackColor = Color.Green;
                    break;
                case 8:
                    button8.BackColor = Color.Green;
                    break;
                case 9:
                    button9.BackColor = Color.Green;
                    break;
                case 10:
                    button10.BackColor = Color.Green;
                    break;
                case 11:
                    button11.BackColor = Color.Green;
                    break;
                case 12:
                    button12.BackColor = Color.Green;
                    break;
                case 13:
                    button13.BackColor = Color.Green;
                    break;
                case 14:
                    button14.BackColor = Color.Green;
                    break;
                case 15:
                    button15.BackColor = Color.Green;
                    break;
                case 16:
                    button16.BackColor = Color.Green;
                    break;
            }
        }
        /// <summary>
        /// Cyklus pro zapis lepsiho casu do listboxu
        /// </summary>
        private void Zapis()
        {
            timer1.Stop();
            DateTime dt2 = DateTime.Now;
            TimeSpan minulyCas = konecnyCas;
            konecnyCas = dt2 - dt;
            if (minulyCas > konecnyCas)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(konecnyCas.ToString());
            }
            else
            {

                listBox1.Items.Add("Minuly cas byl lepsi");
            }
            return;
        }
        /// <summary>
        /// Cyklus vyuzivajici funkce Generace a Zapis
        /// </summary>
        private void Cyklus()
        {
            if (pocet == 10)
            {
                Zapis();
            }
            else
            {
                Generace();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pocet = 0;
            ++pokusy;
            timer1.Start();
            dt = DateTime.Now;
            Generace();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Green)
            {
                button1.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Green)
            {
                button2.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Green)
            {
                button3.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Green)
            {
                button4.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Green)
            {
                button5.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Green)
            {
                button6.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Green)
            {
                button7.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Green)
            {
                button8.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Green)
            {
                button9.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Green)
            {
                button10.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Green)
            {
                button11.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Green)
            {
                button12.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Green)
            {
                button13.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Green)
            {
                button14.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Green)
            {
                button15.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Green)
            {
                button16.BackColor = Color.Red;
                ++pocet;

                Cyklus();
            }
        }
    }
}
