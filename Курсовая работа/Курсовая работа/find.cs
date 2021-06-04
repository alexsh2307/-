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
    public partial class find : Form
    {
        private startScreen startScreen;
        internal find(startScreen s)
        {
            startScreen = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(musical_instrument a in startScreen.musical_Instruments)
            {
                if(a.name == textBox1.Text)
                {
                    textBox2.Text = a.price.ToString();
                    comboBox1.Text = a.availability ? "Да" : "Нет";
                    textBox4.Text = a.articleNumber;
                    textBox5.Text = a.type;
                    textBox6.Text = a.subtype;
                    textBox7.Text = a.discount.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            startScreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (musical_instrument a in startScreen.musical_Instruments)
            {
                if (a.name == textBox1.Text)
                {
                    bool f = true;

                    int price;
                    if (int.TryParse(textBox2.Text, out price) && textBox2.Text.Length > 0)
                    {
                        if (price < 0)
                        {
                            textBox2.BackColor = Color.Red;
                            f = false;
                        }
                        else
                        {
                            a.price = price;
                        }
                    }

                    a.availability = comboBox1.Text == "Да";
                    a.articleNumber = textBox4.Text;
                    a.type = textBox5.Text;
                    a.subtype = textBox6.Text;

                    int discount;
                    if (int.TryParse(textBox7.Text, out discount) && textBox7.Text.Length > 0)
                    {
                        if (discount < 0 || discount > 99)
                        {
                            textBox7.BackColor = Color.Red;
                            f = false;
                        }
                        else
                        {
                            a.discount = discount;
                        }
                    }
                    else
                    {
                        f = false;
                        textBox7.BackColor = Color.Red;
                    }

                    if (f)
                    {
                        foreach(ListViewItem b in startScreen.listView1.Items)
                        {
                            if (b.Text == a.name)
                            {
                                b.SubItems[1].Text = a.price.ToString();
                                b.SubItems[2].Text = a.availability ? "Да" : "Нет";
                                b.SubItems[3].Text = a.articleNumber;
                                b.SubItems[4].Text = a.type;
                                b.SubItems[5].Text = a.subtype;
                                b.SubItems[6].Text = a.discount.ToString();
                                break;
                            }
                        }
                        startScreen.Show();
                        this.Close();
                    }
                }
            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
