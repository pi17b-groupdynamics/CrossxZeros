using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;

namespace CrossxZeros
{
    public partial class Form1 : Form
    {
        List<Color> colors = new List<Color>();
        int currentColor = 0;
        int a = 0;
        public Form1()
        {
            InitializeComponent();

            colors.Add(Color.FromArgb(3, 169, 244));
            colors.Add(Color.FromArgb(33, 150, 243));
            colors.Add(Color.FromArgb(0, 150, 136));
            colors.Add(Color.FromArgb(103, 58, 183));
            colors.Add(Color.FromArgb(156, 39, 176));
            colors.Add(Color.FromArgb(255, 87, 34));
            colors.Add(Color.FromArgb(255, 193, 7));
            colors.Add(Color.FromArgb(205, 220, 57));
            colors.Add(Color.FromArgb(0, 255, 0));
            colors.Add(Color.FromArgb(0, 100, 0));
            colors.Add(Color.FromArgb(32, 178, 170));
        }

        private void startMenu1_Load(object sender, EventArgs e)
        { 

        }

        private void startMenu1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSettings.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gameScreen.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            startMenu.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startMenu.BringToFront();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (gameScreen.Height - 200<gameScreen.Width-900)
            {
                Battlefield.Width = gameScreen.Height - 198;
                Battlefield.Height = gameScreen.Height - 198;
            }
            else
            {
                Battlefield.Width = gameScreen.Width - 898;
                Battlefield.Height = gameScreen.Width - 898;
            }
            Battlefield.Left = (gameScreen.Width - Battlefield.Width) / 2;
            Battlefield.Top = (gameScreen.Height - Battlefield.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (gameScreen.Height - 200 < gameScreen.Width - 900)
            {
                Battlefield.Width = gameScreen.Height - 198;
                Battlefield.Height = gameScreen.Height - 198;
            }
            else
            {
                Battlefield.Width = gameScreen.Width - 898;
                Battlefield.Height = gameScreen.Width - 898;
            }
            Battlefield.Left = (gameScreen.Width - Battlefield.Width) / 2;
            Battlefield.Top = (gameScreen.Height - Battlefield.Height) / 2;
        }

        private void Battlefield_SizeChanged(object sender, EventArgs e)
        {
            int w = (Battlefield.Width - 10) / 3;
            p11.Width = (p11.Height = w);
            p12.Width = (p12.Height = w);
            p12.Left = w + 5;
            p13.Width = (p13.Height = w);
            p13.Left = 2 * w + 8;
            p21.Width = (p21.Height = w);
            p21.Top = w + 5;
            p22.Width = (p22.Height = w);
            p22.Top = w + 5;
            p22.Left = w + 5;
            p23.Width = (p23.Height = w);
            p23.Top = w + 5;
            p23.Left = 2 * w + 8;
            p31.Width = (p31.Height = w);
            p31.Top = 2 * w + 8;
            p32.Width = (p32.Height = w);
            p32.Top = 2 * w + 8;
            p32.Left = w + 5;
            p33.Width = (p33.Height = w);
            p33.Top = 2 * w + 8;
            p33.Left = 2 * w + 8;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(currentColor < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentColor], colors[currentColor + 1]);

                if(a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentColor++;
                }
                timer1.Enabled = true;
            }
            else 
            {
                currentColor = 0;
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentColor], colors[currentColor + 1]);

                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentColor++;
                }
                timer1.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
    }

}
