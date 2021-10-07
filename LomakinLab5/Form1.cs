using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LomakinLab5
{
    public partial class Form1 : Form
    {
        Graphics g;
        int count = 1;
        int i = 1;
        int r = 5;
        int switcher = 0;
        Pen myPen = new Pen(Color.Red);
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            comboBox1.SelectedIndex = 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                myPen.Color = colorDialog1.Color;
                panel1.Visible = false;
                timer1.Enabled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            count = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            r = trackBar2.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switcher = comboBox1.SelectedIndex;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 0 && i!=count)
            {
                switch (switcher)
                {
                    case 0:
                        {
                            g.DrawEllipse(myPen, Form1.ActiveForm.Width / 2 - i * r, Form1.ActiveForm.Height / 2 - i * r, i * r * 2, i * r * 2);
                            break;
                        }
                    case 1:
                        {
                            g.DrawRectangle(myPen, Form1.ActiveForm.Width / 2 - i * r, Form1.ActiveForm.Height / 2 - i * r, i * r * 2, i * r * 2);
                            break;
                        }
                }
                i++;
            }
            //else timer1.Enabled = false;
        }
    }
}
