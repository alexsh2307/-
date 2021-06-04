using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class get : Form
    {
        private startScreen startScreen;
        public get(startScreen s)
        {
            InitializeComponent();
            startScreen = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBox1.Text;
                StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] str = line.Split(' ');
                    startScreen.musical_Instruments.Add(new musical_instrument(str[0], Convert.ToInt32(str[1]), Convert.ToBoolean(str[2]), str[3], str[4], str[5], Convert.ToInt32(str[6])));
                }
                startScreen.showList();
                startScreen.Show();
                this.Close();
            }
            catch
            {
                textBox1.BackColor = Color.Red;
            }
        }
    }
}
