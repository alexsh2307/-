using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class add : Form
    {
        private startScreen startScreen;
        internal add(startScreen s)
        {
            startScreen = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = true;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            comboBox1.BackColor = Color.White;

            if(textBox1.Text.Length == 0)
            {
                f = false;
                textBox1.BackColor = Color.Red;
            }

            int price;
            if (int.TryParse(textBox2.Text, out price) && textBox2.Text.Length > 0)
            {
                if (price < 0)
                {
                    textBox2.BackColor = Color.Red;
                    f = false;
                }
            }
            else
            {
                f = false;
                textBox2.BackColor = Color.Red;
            }

            int discount;
            if (int.TryParse(textBox7.Text, out discount) && textBox7.Text.Length > 0)
            {
                if (discount < 0 || discount > 99)
                {
                    textBox7.BackColor = Color.Red;
                    f = false;
                }
            }
            else
            {
                f = false;
                textBox7.BackColor = Color.Red;
            }

            bool availability = true;
            if (comboBox1.Text.Length > 0)
            {
                if (comboBox1.Text == "Нет")
                {
                    availability = false;
                }
            }
            else
            {
                f = false;
                comboBox1.BackColor = Color.Red;
            }

            if (f)
            {
                musical_instrument musical = new musical_instrument(textBox1.Text, price, availability, textBox4.Text, textBox5.Text, textBox6.Text, discount);
                startScreen.Add(musical);
                startScreen.Show();
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
