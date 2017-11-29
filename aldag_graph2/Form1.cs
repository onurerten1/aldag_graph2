using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aldag_graph2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)    
            {
                case 0:
                    {
                        pictureBox1.Image = Properties.Resources.AE100_27C;
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Properties.Resources.AE200_27C;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Properties.Resources.AE200_27C__SULU_;
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Properties.Resources.AE300_27C;
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Image = Properties.Resources.AE350_27C;
                        break;
                    }
                case 5:
                    {
                        pictureBox1.Image = Properties.Resources.AE400_27C__TEK_FAN_;
                        break;
                    }
                case 6:
                    {
                        pictureBox1.Image = Properties.Resources.AE400_27C__ÇİFT_FAN_;
                        break;
                    }
                case 7:
                    {
                        pictureBox1.Image = Properties.Resources.AE700_27C;
                        break;
                    }
                case 8:
                    {
                        pictureBox1.Image = Properties.Resources.AE900_27C;
                        break;
                    }
            }
        }
    }
}
