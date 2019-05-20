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
        int p1_wins, p2_wins;
        int first_player = 0,col_wins; //кто первый ходит; количество побед
        int num_step, active_player;
        bool playr_enemy = false;
        bool p1_cross, p2_cross; //Кто крестик(false - ноль)
        int language = 0;
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
        void start_battle() // Чистка поля после боя
        {
            num_step = 1; // номер хода
            p11.Enabled = true;
            p11.Image = null;
            // Включаем кнопку и удаляем изборажение
            p12.Enabled = true;
            p12.Image = null;
            p13.Enabled = true;
            p13.Image = null;
            p21.Enabled = true;
            p21.Image = null;
            p22.Enabled = true;
            p22.Image = null;
            p23.Enabled = true;
            p23.Image = null;
            p31.Enabled = true;
            p31.Image = null;
            p32.Enabled = true;
            p32.Image = null;
            p33.Enabled = true;
            p33.Image = null;
        }
        void AI_step()
        {
            if(num_step ==1)
            {
                
            }
            else if(num_step == 2)
            {

            }
            else if(num_step == 3)
            {

            }
            else if (num_step == 4)
            {

            }
            else if (num_step == 5)
            {

            }
            else if (num_step == 6)
            {

            }
            else if (num_step == 7)
            {

            }
            else if (num_step == 8)
            {

            }
            else if (num_step == 9)
            {

            }

        }
        void check_victory() // проверка победы
        {

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
            col_wins = 1;
            start_battle();
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
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            first_player = 0;
        }

        private void radioButton1_Click(object sender, EventArgs e) { }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            first_player = 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gameScreen.BringToFront();
            col_wins = 3;
            start_battle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameScreen.BringToFront();
            col_wins = 5;
            start_battle();
        }

        private void Bot_CheckedChanged(object sender, EventArgs e) // компьютер панель справа
        {
            playr_enemy = true;
            player2.Enabled = false;
        }

        private void People_CheckedChanged(object sender, EventArgs e)
        {
            playr_enemy = false;
            player2.Enabled = true;
        }

        private void p11_Click(object sender, EventArgs e) //Кнопки для поля первая слева вверху
        {
            p11.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }
        private void p12_Click(object sender, EventArgs e)
        {
            p12.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void p13_Click(object sender, EventArgs e)
        {
            p13.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void p21_Click(object sender, EventArgs e)
        {
            p21.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void p22_Click(object sender, EventArgs e)
        {
            p22.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void p23_Click(object sender, EventArgs e)
        {
            p23.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void p31_Click(object sender, EventArgs e)
        {
            p31.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (language == 0)
            {
                button1.Text = "Play";
                button11.Text = "Exit";
                button7.Text = "Multiplayer stats";
                dataGridViewTextBoxColumn1.HeaderText = "Nick";
                dataGridViewTextBoxColumn2.HeaderText = "Wins";
                dataGridViewTextBoxColumn3.HeaderText = "Loses";
                Побед.HeaderText = "Wins";
                Ник.HeaderText = "Nick";
                Поражений.HeaderText = "Loses";
                button6.Text = "Solo game stats";
                groupBox2.Text = "Player 1";
                groupBox3.Text = "Player 2";
                People.Text = "Human";
                Bot.Text = "Bot";
                groupBox1.Text = "Walks First:";
                radioButton1.Text = "Player 1";
                radioButton2.Text = "Player 2";
                radioButton3.Text = "Random";
                button9.Text = "Before the 1 victory";
                button8.Text = "Before the 3 victory";
                button4.Text = "Before the 5 victory";
                button2.Text = "Back";
                button10.Text = "Menu";
                language = 1;
            }
            else if(language == 1)
            {
                button1.Text = "Играть";
                button11.Text = "Выход";
                button7.Text = "Статистика многопользовательской игры";
                dataGridViewTextBoxColumn1.HeaderText = "Ник";
                dataGridViewTextBoxColumn2.HeaderText = "Побед";
                dataGridViewTextBoxColumn3.HeaderText = "Поражений";
                Побед.HeaderText = "Побед";
                Ник.HeaderText = "Ник";
                Поражений.HeaderText = "Поражений";
                button6.Text = "Статистика одиночной игры";
                groupBox2.Text = "Игрок 1";
                groupBox3.Text = "Игрок 2";
                People.Text = "Человек";
                Bot.Text = "Бот";
                groupBox1.Text = "Ходит первым:";
                radioButton1.Text = "Игрок 1";
                radioButton2.Text = "Игрок 2";
                radioButton3.Text = "Определить рандомно";
                button9.Text = "До 1 победы";
                button8.Text = "До 3 побед";
                button4.Text = "До 5 побед";
                button2.Text = "Назад";
                button10.Text = "Меню";
                language = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p32_Click(object sender, EventArgs e)
        {
            p32.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void p33_Click(object sender, EventArgs e)
        {
            p33.Enabled = false;
            //меняем картинку на Х или О
            num_step++;
            if (playr_enemy)
            {
                AI_step();
            }
            else
            {
                // передача хода другому игроку
            }
            check_victory();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            first_player = 1;
        }
    }

}
