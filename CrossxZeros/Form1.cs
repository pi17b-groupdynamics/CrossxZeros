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

namespace CrossxZeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                Battlefield.Width = gameScreen.Height - 200;
                Battlefield.Height = gameScreen.Height - 200;
            }
            else
            {
                Battlefield.Width = gameScreen.Width - 900;
                Battlefield.Height = gameScreen.Width - 900;
            }
            Battlefield.Left = (gameScreen.Width - Battlefield.Width) / 2;
            Battlefield.Top = (gameScreen.Height - Battlefield.Height) / 2;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (gameScreen.Height - 200 < gameScreen.Width - 900)
            {
                Battlefield.Width = gameScreen.Height - 200;
                Battlefield.Height = gameScreen.Height - 200;
            }
            else
            {
                Battlefield.Width = gameScreen.Width - 900;
                Battlefield.Height = gameScreen.Width - 900;
            }
            Battlefield.Left = (gameScreen.Width - Battlefield.Width) / 2;
            Battlefield.Top = (gameScreen.Height - Battlefield.Height) / 2;
            int w = (Battlefield.Width - 10) / 3;
            p11.Width = (p11.Height = w);
            p12.Width = (p12.Height = w);
            p12.Left = w + 5;
            p13.Width = (p13.Height = w);
            p12.Left = 2 * w + 8;
            p21.Width = (p21.Height = w);
            p21.Top = w + 5;
            p22.Width = (p22.Height = w);
            p22.Top = w + 5;
            p22.Left = w + 5;
            p23.Width = (p23.Height = w);
            p23.Top = w + 8;
            p23.Left = 2 * w + 8;
            p31.Width = (p31.Height = w);
            p31.Top = 2 * w + 8;
            p32.Width = (p32.Height = w);
            p32.Top = 2 * w + 8;
            p32.Left = w + 8;
            p33.Width = (p33.Height = w);
            p33.Top = 2 * w + 8;
            p33.Left = 2 * w + 8;
        }
    }

}
