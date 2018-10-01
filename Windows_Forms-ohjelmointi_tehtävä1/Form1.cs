using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_ohjelmointi_tehtävä1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void torppaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Carolus Kotilainen!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            textBox1.Text = "0";
            textBox2.Text = "[Syötä elokuvan nimi]";
            textBox3.Text = currentYear;
            textBox4.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //id
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //nimi
        }
        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "[Syötä elokuvan nimi]";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //julkaisuvuosi
        }
        private void TextBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                string currentYear = DateTime.Now.Year.ToString();
                textBox3.Text = currentYear;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //kesto
        }
        private void TextBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
        private void TextBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tallenna nappi
            int i = 0;
            string numerotesti = textBox3.Text;
            bool testi = numerotesti.All(char.IsDigit);
            if (textBox3.Text == "")
            {
                MessageBox.Show("Et ole syöttänyt mitään julkaisuvuosi kenttään");
            } else if (testi == true)
            {
                i++;
            } else
            {
                MessageBox.Show("Julkaisuvuosi kentässä on muita merkkejä kuin numeroita");
            }
            string numerotesti2 = textBox4.Text;
            bool testi2 = numerotesti2.All(char.IsDigit);
            if (textBox4.Text == "")
            {
                MessageBox.Show("Et ole syöttänyt mitään kesto kenttään");
            }
            else if (testi2 == true)
            {
                i++;
            }
            else
            {
                MessageBox.Show("Kesto kentässä on muita merkkejä kuin numeroita");
            }
            if (i == 2)
            {
                MessageBox.Show("Check OK!");
            }
        }
    }
}
