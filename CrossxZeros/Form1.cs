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
        }
    }

}
