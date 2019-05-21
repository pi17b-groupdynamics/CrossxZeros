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
using CrossxZeros.Properties;

namespace CrossxZeros
{
    public partial class Form1 : Form
    {
        List<Color> colors = new List<Color>();
        int currentColor = 0;
        int a = 0;
        int language = 0;
        private bool isCollapsed;
        private bool SoundSt;
        int count_of_wins;
        int check_on_wins = 0;
        int winner_cross = 0;
        int winner_zero = 0;
        bool human = true;
        int side = 1;
        int timer = 0;
        int timer_2 = 0;
        int turn = 1; // 1- крестик, 0 - нолик; череда хода
        int one=2, two=2, three=2, four=2, five=2, six=2, seven=2, eight=2, nine = 2;
        bool checkpoint = false;
        int first_numb = 1;
        int second_numb = 1;
        int another_timer = 0;
        bool border_check = false;
        bool check_win_or_not = false;
        object sender = null;
        EventArgs e = null;
        string lane = "11";
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
          /*p11.Enabled = true;
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
            p33.Image = null;*/

           
            turn = 1;
            one = 2; two = 2; three = 2; four = 2; five = 2; six = 2; seven = 2; eight = 2; nine = 2;
            timer5.Enabled = true;

            
        }

        void start_battle_menu()
        {
            turn = 1;
            one = 2; two = 2; three = 2; four = 2; five = 2; six = 2; seven = 2; eight = 2; nine = 2;
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
    
        private void startMenu1_Load(object sender, EventArgs e)
        { 

        }

        private void startMenu1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSettings.BringToFront();
            if (!isCollapsed)
            {
                timer2.Start();
            }
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(side == 1)
            {
                pictureBox10.Image = Resources.LTK5AdoTa;
                pictureBox11.Image = Resources.letter_o_png_letter_o_icon_068645_512;
            }
            else
            {
                pictureBox10.Image = Resources.letter_o_png_letter_o_icon_068645_512;
                pictureBox11.Image = Resources.LTK5AdoTa;
            }
            timer4.Enabled = true;
            if(player1.Text == "")
            {
                player1.Text = "Player_1";
                label1.Text = player1.Text;
            }
            else
            {
                label1.Text = player1.Text;
            }
            if (player2.Text == "" && human == true)
            {
                player2.Text = "Player_2";
                label2.Text = player2.Text;
            }
            else
            {
                label2.Text = player2.Text;
            }
            count_of_wins = 1;
            gameScreen.BringToFront();
            sound.BringToFront();
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (side == 1)
            {
                pictureBox10.Image = Resources.LTK5AdoTa;
                pictureBox11.Image = Resources.letter_o_png_letter_o_icon_068645_512;
            }
            else
            {
                pictureBox10.Image = Resources.letter_o_png_letter_o_icon_068645_512;
                pictureBox11.Image = Resources.LTK5AdoTa;
            }
            timer4.Enabled = true;
            if (player1.Text == "")
            {
                player1.Text = "Player_1";
                label1.Text = player1.Text;
            }
            else
            {
                label1.Text = player1.Text;
            }
            if (player2.Text == "")
            {
                player2.Text = "Player_2";
                label2.Text = player2.Text;
            }
            else
            {
                label2.Text = player2.Text;
            }
            count_of_wins = 3;
            gameScreen.BringToFront();
            sound.BringToFront();
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (side == 1)
            {
                pictureBox10.Image = Resources.LTK5AdoTa;
                pictureBox11.Image = Resources.letter_o_png_letter_o_icon_068645_512;
            }
            else
            {
                pictureBox10.Image = Resources.letter_o_png_letter_o_icon_068645_512;
                pictureBox11.Image = Resources.LTK5AdoTa;
            }
            timer4.Enabled = true;
            if (player1.Text == "")
            {
                player1.Text = "Player_1";
                label1.Text = player1.Text;
            }
            else
            {
                label1.Text = player1.Text;
            }
            if (player2.Text == "")
            {
                player2.Text = "Player_2";
                label2.Text = player2.Text;
            }
            else
            {
                label2.Text = player2.Text;
            }
            count_of_wins = 5;
            gameScreen.BringToFront();
            sound.BringToFront();
            if (!SoundSt)
            {
                timer3.Start();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            startMenu.BringToFront();
            style.BringToFront();
            sound.BringToFront();
            style.Show();
            timer4.Enabled = false;
            timer = 0;
            label3.Text = "";
            start_battle_menu();
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startMenu.BringToFront();
            style.BringToFront();
            sound.BringToFront();
            style.Show();
            if (!SoundSt)
            {
                timer3.Start();
            }
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
            timer2.Start();
            timer3.Start();
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
        private void radioButton1_Click(object sender, EventArgs e) { }
                 

        private void Bot_CheckedChanged(object sender, EventArgs e) // компьютер панель справа
        {
            human = false;
            player2.Text = "Bot";
            player2.Enabled = false;
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void People_CheckedChanged(object sender, EventArgs e)
        {
            human = true;
            player2.Enabled = true;
            player2.Text = "";
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        void wins()
        {
            if (one == 1 && two == 1 && three == 1)
            {

                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }                
            }
            else if(one == 0 && two == 0 && three == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
           else if(one == 1 && five == 1 && nine == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (one == 0 && five == 0 && nine == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (three == 1 && six == 1 && nine == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (three == 0 && six == 0 && nine == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Enabled = true;
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (one == 1 && four == 1 && seven == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (one == 0 && four == 0 && seven == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (seven == 1 && eight == 1 && nine == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (seven == 0 && eight == 0 && nine == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (three == 1 && five == 1 && seven == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (three == 0 && five == 0 && seven == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (three == 1 && six == 1 && nine == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (three == 0 && six == 0 && nine == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (four == 1 && five == 1 && six == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (four == 0 && five == 0 && six == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (two == 1 && five == 1 && eight == 1)
            {
                winner_cross = winner_cross + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
            }
            else if (two == 0 && five == 0 && eight == 0)
            {
                winner_zero = winner_zero + 1;
                check_on_wins = check_on_wins + 1;
                if (check_on_wins == count_of_wins && (winner_cross > winner_zero))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    timer4.Stop();
                    congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    check_win_or_not = true;
                    timer4.Stop();
                    congratulation.Text = player1.Text + " won this match!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
              
            }
            else if((p11.Enabled == false) && (p12.Enabled == false) && (p13.Enabled == false) && (p21.Enabled == false) 
                && (p22.Enabled == false) && (p23.Enabled == false) && (p31.Enabled == false) && (p32.Enabled == false)
                && (p33.Enabled == false))
            {
                check_win_or_not = true;
                timer4.Stop();
                congratulation.Text = "Dead hit!";
                panel4.BringToFront();
                timer6.Start(); ;
            }
        }

        private void p11_Click(object sender, EventArgs e) //Кнопки для поля первая слева вверху
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if(turn == 1)
            {
                p11.Image = Resources.cross;
                p11.Enabled = false;
                turn = 0;
                one = 1;
                timer = 0;
            }
            else
            {
                p11.Image = Resources.zero;
                turn = 1;
                timer = 0;
                one = 0;
                p11.Enabled = false;
            }
            wins();
        }

        private void p12_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p12.Image = Resources.cross;
                p12.Enabled = false;
                timer = 0;
                two = 1;
                turn = 0;
            }
            else
            {
                p12.Image = Resources.zero;
                turn = 1;
                timer = 0;
                two = 0;
                p12.Enabled = false;
            }
            wins();
        }

        private void p13_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p13.Image = Resources.cross;
                p13.Enabled = false;
                turn = 0;
                three = 1;
                timer = 0;
            }
            else
            {
                p13.Image = Resources.zero;
                turn = 1;
                timer = 0;
                three = 0;
                p13.Enabled = false;
            }
            wins();
        }

        private void p21_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p21.Image = Resources.cross;
                p21.Enabled = false;
                timer = 0;
                four = 1;
                turn = 0;
            }
            else
            {
                p21.Image = Resources.zero;
                turn = 1;
                four = 0;
                timer = 0;
                p21.Enabled = false;
            }
            wins();
        }

        private void p22_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p22.Image = Resources.cross;
                p22.Enabled = false;
                five = 1;
                timer = 0;
                turn = 0;
            }
            else
            {
                p22.Image = Resources.zero;
                turn = 1;
                five = 0;
                timer = 0;
                p22.Enabled = false;
            }
            wins();
        }

        private void p23_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p23.Image = Resources.cross;
                p23.Enabled = false;
                six = 1;
                timer = 0;
                turn = 0;
            }
            else
            {
                p23.Image = Resources.zero;
                turn = 1;
                six = 0;
                timer = 0;
                p23.Enabled = false;
            }
            wins();
        }

        private void p31_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p31.Image = Resources.cross;
                p31.Enabled = false;
                timer = 0;
                seven = 1;
                turn = 0;
            }
            else
            {
                p31.Image = Resources.zero;
                turn = 1;
                seven = 0;
                timer = 0;
                p31.Enabled = false;
            }
            wins();
        }

        private void p32_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p32.Image = Resources.cross;
                p32.Enabled = false;
                eight = 1;
                timer = 0;
                turn = 0;
            }
            else if (turn == 0)
            {
                p32.Image = Resources.zero;
                turn = 1;
                eight = 0;
                timer = 0;
                p32.Enabled = false;
            }
            wins();
        }

        private void p33_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p33.Image = Resources.cross;
                p33.Enabled = false;
                timer = 0;
                nine = 1;
                turn = 0;
            }
            else
            {
                p33.Image = Resources.zero;
                turn = 1;
                nine = 0;
                timer = 0;
                p33.Enabled = false;
            }
            wins();
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
                button3.Text = "Style";
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
                button3.Text = "Стиль";
                language = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button3.Image = Resources.Collapse_Arrow_20px;
                style.Height += 20;
                if (style.Size == style.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button3.Image = Resources.Expand_Arrow_20px;
                style.Height -= 20;
                if (style.Size == style.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void startMenu_Click(object sender, EventArgs e)
        {
            if(!isCollapsed)
            {
                timer2.Start();
            }
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            timer3.Start();
            if (border_check == false)
            {
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                border_check = true;
            }
            else
            {
                pictureBox2.BorderStyle = BorderStyle.None;
                border_check = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(!sound.Visible)
                sound.Show();
            if (SoundSt)
            {
                
                sound.Height += 20;
                if (sound.Size == sound.MaximumSize)
                {
                    timer3.Stop();
                    SoundSt = false;
                }
            }
            else
            {
                sound.Height -= 20;
                if (sound.Size == sound.MinimumSize)
                {
                    timer3.Stop();
                    sound.Hide();
                    SoundSt = true;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer_2 = timer_2 + 1;
            if(timer_2 == 2)
            {
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
                label4.Text = "";
                timer_2 = 0;
                timer5.Enabled = false;
            }
          

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            another_timer = another_timer + 1;
            if (another_timer == 4 && check_win_or_not == false)
            {
                winner_zero = 0;
                winner_cross = 0;
                check_on_wins = 0;
                another_timer = 0;
                timer = 0;
                button10_Click(sender, e);
                congratulation.Text = "";
                timer6.Stop();
            }
            else if(another_timer == 4 && check_win_or_not == true)
            {
                another_timer = 0;
                timer = 0;
                timer4.Start();
                start_battle_menu();
                gameScreen.BringToFront();
                timer6.Stop();
            }
        }

        private void player1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(GV2.Visible)
            {
                GV2.Hide();
            }
            else
            {
                GV2.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (GV1.Visible)
            {
                GV1.Hide();
            }
            else
            {
                GV1.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            side = 1;
            if (!SoundSt)
            {
                timer3.Start();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            side = 2;
            if (!SoundSt)
            {
                timer3.Start();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            side = random.Next(1) + 1;
            if (!SoundSt)
            {
                timer3.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int result = 15 - timer;
            label3.Text = result.ToString();
            if(turn == 1 && side == 1)
            {
                pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (turn == 1 && side == 2)
            {
                pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (turn == 0 && side == 1)
            {
                pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            }
            else if(turn == 0 && side == 2)
            {
                pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            }
            timer = timer + 1;
            if (timer < 17)
            {
                if (checkpoint == false)
                {
                    Random random = new Random();
                    first_numb = random.Next(3) + 1;
                    second_numb = random.Next(3) + 1;
                    lane = first_numb.ToString() + second_numb.ToString();
                    checkpoint = true;
                }
                if ((Convert.ToInt32(lane) == 11) && (p11.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p11_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 12) && (p12.Enabled == true))
                {

                    if (timer == 16)
                    {
                        checkpoint = false;
                        p12_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 13) && (p13.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p13_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 21) && (p21.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p21_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 22) && (p22.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p22_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 23) && (p23.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p23_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 31) && (p31.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p31_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 32) && (p32.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p32_Click(sender, e);
                    }
                }
                else if ((Convert.ToInt32(lane) == 33) && (p33.Enabled == true))
                {
                    if (timer == 16)
                    {
                        checkpoint = false;
                        p33_Click(sender, e);
                    }
                }
                else if (checkpoint == true)
                {
                    checkpoint = false;
                }
            }
            else
            {
                if (p11.Enabled == true)
                    p11_Click(sender, e);
                if (p12.Enabled == true)
                    p12_Click(sender, e);
                if (p13.Enabled == true)
                    p13_Click(sender, e);
                if (p21.Enabled == true)
                    p21_Click(sender, e);
                if (p22.Enabled == true)
                    p22_Click(sender, e);
                if (p23.Enabled == true)
                    p23_Click(sender, e);
                if (p31.Enabled == true)
                    p31_Click(sender, e);
                if (p32.Enabled == true)
                    p32_Click(sender, e);
                if (p33.Enabled == true)
                    p33_Click(sender, e);
            }
        }
    }

}
