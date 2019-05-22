﻿using System;
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
using System.IO;

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
        bool normal_style = true;
        bool jedi_style = false;
        bool border_check = false;
        bool check_win_or_not = false;
        object sender = null;
        EventArgs e = null;
        string lane = "11";
        int[,] P = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        struct Puti_Win
        {
            public int X;
            public int Y;


        }
        Puti_Win[,] PW = new Puti_Win[8, 3];

        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

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

        void bot_v2()
        {
     
            for(int i = 0; i<8; i++)
            {
                if (P[PW[i, 0].X, PW[i, 0].Y] + P[PW[i, 1].X, PW[i, 1].Y] + P[PW[i, 2].X, PW[i, 2].Y] == turn * 2)
                {
                    if(P[PW[i, 0].X, PW[i, 0].Y] == 0)
                    {
                        if(i == 0)
                        {
                            p11_Click(sender, e);
                            return;
                        }
                        else if(i == 1)
                        {
                            p12_Click(sender, e);
                            return;
                        }
                            else
                        {
                            p13_Click(sender, e);
                            return;
                        }
                    }
                    else if(P[PW[i, 1].X, PW[i, 1].Y] == 0)
                    {
                        if (i == 0)
                        {
                            p21_Click(sender, e);
                            return;
                        }
                        else if (i == 1)
                        {
                            p22_Click(sender, e);
                            return;
                        }
                        else
                        {
                            p23_Click(sender, e);
                            return;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            p31_Click(sender, e);
                            return;
                        }
                        else if (i == 1)
                        {
                            p32_Click(sender, e);
                            return;
                        }
                        else
                        {
                            p33_Click(sender, e);
                            return;
                        }
                    }
               }
                else if (P[PW[i, 0].X, PW[i, 0].Y] + P[PW[i, 1].X, PW[i, 1].Y] + P[PW[i, 2].X, PW[i, 2].Y] == turn * (-2))
                {
                    if (P[PW[i, 0].X, PW[i, 0].Y] == 0)
                    {
                        if (i == 0)
                        {
                            p11_Click(sender, e);
                            return;
                        }
                        else if (i == 1)
                        {
                            p12_Click(sender, e);
                            return;
                        }
                        else
                        {
                            p13_Click(sender, e);
                            return;
                        }
                    }
                    else if (P[PW[i, 1].X, PW[i, 1].Y] == 0)
                    {
                        if (i == 0)
                        {
                            p21_Click(sender, e);
                            return;
                        }
                        else if (i == 1)
                        {
                            p22_Click(sender, e);
                            return;
                        }
                        else
                        {
                            p23_Click(sender, e);
                            return;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            p31_Click(sender, e);
                            return;
                        }
                        else if (i == 1)
                        {
                            p32_Click(sender, e);
                            return;
                        }
                        else
                        {
                            p33_Click(sender, e);
                            return;
                        }
                    }
                }
            }
            if (turn == 1)
            {
                int Bot;
                int hod, hod1;
                String lane1;
                if ((p11.Enabled == true) && (p12.Enabled == true) && (p13.Enabled == true) && (p21.Enabled == true)
                    && (p22.Enabled == true) && (p23.Enabled == true) && (p31.Enabled == true) && (p32.Enabled == true)
                    && (p33.Enabled == true))
                {
                    if (side == 2) // если бот ходит первым
                    {
                        Random random = new Random();
                        hod = random.Next(3) + 1;
                        hod1 = random.Next(3) + 1;

                        lane1 = hod.ToString() + hod1.ToString();
                        checkpoint = true;

                        if (Convert.ToInt32(lane1) == 11)
                        {
                            checkpoint = false;
                            p11_Click(sender, e);
                            one = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 12)
                        {
                            checkpoint = false;
                            p12_Click(sender, e);
                            two = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 13)
                        {
                            checkpoint = false;
                            p13_Click(sender, e);
                            three = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 21)
                        {
                            checkpoint = false;
                            p21_Click(sender, e);
                            four = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 22)
                        {
                            checkpoint = false;
                            p22_Click(sender, e);
                            five = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 23)
                        {
                            checkpoint = false;
                            p23_Click(sender, e);
                            eight = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 31)
                        {
                            checkpoint = false;
                            p31_Click(sender, e);
                            seven = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 32)
                        {
                            checkpoint = false;
                            p32_Click(sender, e);
                            eight = 1;
                        }
                        else if (Convert.ToInt32(lane1) == 33)
                        {
                            checkpoint = false;
                            p33_Click(sender, e);
                            nine = 1;
                        }
                    }
                }
                // 2 ход
                else if ((one == 1) && (two == 2) && (three == 2) && (four == 2) && (five == 0) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if (((one == 1) && (two == 0) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2)))
                {
                    p22_Click(sender, e);
                }
                else if (((one == 1) && (two == 2) && (three == 0) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2)) || ((one == 1) &&
                    (two == 2) && (three == 2) && (four == 0) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2)) ||
                    ((one == 1) && (two == 2) && (three == 2) && (four == 0) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2)) ||
                    ((one == 1) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 0) && (seven == 2) && (eight == 2) && (nine == 2)) ||
                    ((one == 1) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 0) && (eight == 2) && (nine == 2)) ||
                    ((one == 1) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 0) && (nine == 2)) ||
                    ((one == 1) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 0)))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 1) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 0) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 2) && (four == 0) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 2) && (four == 2) && (five == 0) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 2) && (four == 2) && (five == 2) &&
                      (six == 0) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 0) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((p11.Enabled == true) && (two == 1) && (eight == 0) && (p12.Enabled == false) && (p13.Enabled == true) && (p21.Enabled == true)
           && (p22.Enabled == true) && (p23.Enabled == true) && (p31.Enabled == true) && (p32.Enabled == false)
           && (p33.Enabled == true))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 2) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 1) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 1) && (four == 2) && (five == 2) &&
                    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 1) && (four == 0) && (five == 2) &&
        (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    Random random = new Random();
                    Bot = random.Next(2) + 1;
                    if (Bot == 1)
                    {
                        p22_Click(sender, e);
                    }
                    else
                    {
                        p31_Click(sender, e);
                    }
                }
                else if ((one == 2) && (two == 2) && (three == 1) && (four == 2) && (five == 0) &&
                   (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p31_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 1) && (four == 2) && (five == 2) &&
                   (six == 0) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 1) && (four == 2) && (five == 2) &&
                   (six == 2) && (seven == 0) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 1) && (four == 2) && (five == 2) &&
                   (six == 2) && (seven == 2) && (eight == 0) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 1) && (four == 2) && (five == 2) &&
                   (six == 2) && (seven == 2) && (eight == 2) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 2) && (four == 1) && (five == 2) &&
                   (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 2) && (four == 1) && (five == 2) &&
                 (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 1) && (five == 2) &&
                 (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 1) && (five == 0) &&
                 (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p31_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 1) && (five == 2) &&
                 (six == 0) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 1) && (five == 2) &&
                 (six == 2) && (seven == 0) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 1) && (five == 2) &&
                 (six == 2) && (seven == 2) && (eight == 0) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 1) && (five == 2) &&
                 (six == 2) && (seven == 2) && (eight == 2) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 2) && (four == 2) && (five == 1) &&
                 (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 2) && (four == 2) && (five == 1) &&
                 (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 2) && (five == 1) &&
                (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 0) && (five == 1) &&
                (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 1) &&
                (six == 0) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 1) &&
                (six == 2) && (seven == 0) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 1) &&
                (six == 2) && (seven == 2) && (eight == 0) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 1) &&
                (six == 2) && (seven == 2) && (eight == 2) && (nine == 0))
                {
                    p11_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
                (six == 1) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 2) && (four == 2) && (five == 2) &&
               (six == 1) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 2) && (five == 2) &&
              (six == 1) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 0) && (five == 2) &&
              (six == 1) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 0) &&
             (six == 1) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    Random random = new Random();
                    Bot = random.Next(2) + 1;
                    if (Bot == 1)
                    {
                        p31_Click(sender, e);
                    }
                    else
                    {
                        p33_Click(sender, e);
                    }
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
             (six == 1) && (seven == 0) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
             (six == 1) && (seven == 2) && (eight == 0) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
           (six == 1) && (seven == 2) && (eight == 2) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
           (six == 2) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 2) && (four == 2) && (five == 2) &&
           (six == 2) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 2) && (five == 2) &&
         (six == 2) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 0) && (five == 2) &&
        (six == 2) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 0) &&
        (six == 2) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
        (six == 0) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
        (six == 2) && (seven == 1) && (eight == 0) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
        (six == 2) && (seven == 1) && (eight == 2) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
        (six == 2) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 2) && (four == 2) && (five == 2) &&
       (six == 2) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 0) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 0) &&
      (six == 2) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 0) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 0) && (eight == 1) && (nine == 2))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 1) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 0) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 0) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 0) &&
      (six == 2) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p11_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 0) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 0) && (eight == 2) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 2) && (four == 2) && (five == 2) &&
      (six == 2) && (seven == 2) && (eight == 0) && (nine == 1))
                {
                    p22_Click(sender, e);
                }
                // 3 ход
                else if ((one == 1) && (two == 2) && (three == 0) && (four == 0) && (five == 1) &&
    (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((one == 2) && (two == 1) && (three == 0) && (four == 0) && (five == 1) &&
  (six == 2) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p32_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 0) && (five == 1) &&
 (six == 1) && (seven == 2) && (eight == 2) && (nine == 2))
                {
                    p21_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 0) && (five == 1) &&
 (six == 2) && (seven == 1) && (eight == 2) && (nine == 2))
                {
                    p21_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 0) && (five == 1) &&
 (six == 2) && (seven == 2) && (eight == 1) && (nine == 2))
                {
                    p12_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 0) && (five == 1) &&
 (six == 2) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p11_Click(sender, e);
                }
                else if ((one == 2) && (two == 2) && (three == 0) && (four == 0) && (five == 1) &&
   (six == 1) && (seven == 2) && (eight == 2) && (nine == 1))
                {
                    p21_Click(sender, e);
                }
                else if ((one == 0) && (two == 2) && (three == 0))
                {
                    p12_Click(sender, e);
                }
                else if((one == 0) && (four == 2) && (seven == 0))
                {
                    p21_Click(sender, e);
                }
                else if ((three == 0) && (six == 2) && (nine == 0))
                {
                    p23_Click(sender, e);
                }
                else if ((seven == 0) && (eight == 2) && (nine == 0))
                {
                    p32_Click(sender, e);
                }
                else if ((one == 0) && (five ==2) && (nine == 0))
                {
                    p22_Click(sender, e);
                }
                else if ((one == 2) && (five == 0) && (nine == 0))
                {
                    p11_Click(sender, e);
                }
                else if ((one == 0) && (five == 0) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
                else if ((seven == 2) && (eight == 0) && (nine == 0))
                {
                    p31_Click(sender, e);
                }
                else if ((seven == 0) && (eight == 0) && (nine == 2))
                {
                    p33_Click(sender, e);
                }
            }
            else if (turn == -1)
            {
                p12_Click(sender, e);
            }
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
            if (human == true)
            {
                timer4.Enabled = true;
            }

            if (player1.Text == "")
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
            if(human == false )
            {
                bot_v2();
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
            if (human == true)
            {
                timer4.Enabled = true;
            }
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
            if (human == false && turn == 1)
            {
                bot_v2();
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
            if (human == true)
            {
                timer4.Enabled = true;
            }
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
            if (human == false && turn == 1)
            {
                bot_v2();
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
            for(int i = 0; i<3; i++)
            {
                for(int j =0; j< 3; j++)
                {
                    P[i, j] = 0;
                }
            }
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
            if (gameScreen.Height - 200<gameScreen.Width-800)
            {
                Battlefield.Width = gameScreen.Height - 198;
                Battlefield.Height = gameScreen.Height - 198;
            }
            else
            {
                Battlefield.Width = gameScreen.Width - 798;
                Battlefield.Height = gameScreen.Width - 798;
            }
            Battlefield.Left = (gameScreen.Width - Battlefield.Width) / 2;
            Battlefield.Top = (gameScreen.Height - Battlefield.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (gameScreen.Height - 200 < gameScreen.Width - 800)
            {
                Battlefield.Width = gameScreen.Height - 198;
                Battlefield.Height = gameScreen.Height - 198;
            }
            else
            {
                Battlefield.Width = gameScreen.Width - 798;
                Battlefield.Height = gameScreen.Width - 798;
            }
            Battlefield.Left = (gameScreen.Width - Battlefield.Width) / 2;
            Battlefield.Top = (gameScreen.Height - Battlefield.Height) / 2;
            timer2.Start();
            timer3.Start();
            PW[0, 0].X = 0;
            PW[0, 1].X = 0;
            PW[0, 2].X = 0;
            PW[0, 0].Y = 0;
            PW[0, 1].Y = 1;
            PW[0, 2].Y = 2;

            PW[1, 0].X = 1;
            PW[1, 1].X = 1;
            PW[1, 2].X = 1;
            PW[1, 0].Y = 0;
            PW[1, 1].Y = 1;
            PW[1, 2].Y = 2;

            PW[2, 0].X = 2;
            PW[2, 1].X = 2;
            PW[2, 2].X = 2;
            PW[2, 0].Y = 0;
            PW[2, 1].Y = 1;
            PW[2, 1].Y = 2;

            PW[3, 0].X = 0;
            PW[3, 1].X = 1;
            PW[3, 2].X = 2;
            PW[3, 0].Y = 0;
            PW[3, 1].Y = 0;
            PW[3, 2].Y = 0;

            PW[4, 0].X = 0;
            PW[4, 1].X = 1;
            PW[4, 2].X = 2;
            PW[4, 0].Y = 1;
            PW[4, 1].Y = 1;
            PW[4, 2].Y = 1;

            PW[5, 0].X = 0;
            PW[5, 1].X = 1;
            PW[5, 2].X = 2;
            PW[5, 0].Y = 2;
            PW[5, 1].Y = 2;
            PW[5, 2].Y = 2;

            PW[6, 0].X = 0;
            PW[6, 1].X = 1;
            PW[6, 2].X = 2;
            PW[6, 0].Y = 0;
            PW[6, 1].Y = 1;
            PW[6, 2].Y = 2;

            PW[7, 0].X = 2;
            PW[7, 1].X = 1;
            PW[7, 2].X = 0;
            PW[7, 0].Y = 0;
            PW[7, 1].Y = 1;
            PW[7, 2].Y = 2;

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
            pictureBox14.Width = gameScreen.Width / 2;
            pictureBox15.Width = gameScreen.Width / 2;
        } 
            else 
        { 
             WindowState = FormWindowState.Normal; 
             FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow; 
             pictureBox14.Width = gameScreen.Width / 2; 
             pictureBox15.Width = gameScreen.Width / 2; 
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
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
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else if (check_on_wins == count_of_wins && (winner_zero > winner_cross))
                {
                    Battlefield.Hide();
                    check_win_or_not = false;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = "Congratulation!\n" + player2.Text + " won this game!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = "Поздравляем!\n" + player2.Text + " выиграл игру!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = "Congratulation!\n" + player1.Text + " won this game!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = "Поздравляем!\n" + player1.Text + " выиграл игру!";
                    panel4.BringToFront();
                    timer6.Start();
                }
                else
                {
                    Battlefield.Hide();
                    check_win_or_not = true;
                    timer4.Stop();
                    if (language == 1 && side == 1)
                        congratulation.Text = player2.Text + " won this match!";
                    else if (language == 0 && side == 1)
                        congratulation.Text = player2.Text + " выиграл этот матч!";
                    else if (language == 1 && side == 2)
                        congratulation.Text = player1.Text + " won this match!";
                    else if (language == 0 && side == 2)
                        congratulation.Text = player1.Text + " выиграл этот матч!";
                    panel4.BringToFront();
                    start_battle_menu();
                    timer6.Start();
                }
              
            }
            else if((p11.Enabled == false) && (p12.Enabled == false) && (p13.Enabled == false) && (p21.Enabled == false) 
                && (p22.Enabled == false) && (p23.Enabled == false) && (p31.Enabled == false) && (p32.Enabled == false)
                && (p33.Enabled == false))
            {
                Battlefield.Hide();
                check_win_or_not = true;
                timer4.Stop();
                if(language == 0)
                    congratulation.Text = "Dead hit!";
                else
                    congratulation.Text = "Ничья!";
                panel4.BringToFront();
                timer6.Start(); ;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    P[i, j] = 0;
                }
            }
        }

        private void p11_Click(object sender, EventArgs e) //Кнопки для поля первая слева вверху
        {
            P[0, 0] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if(turn == 1)
            {
                p11.Image = Resources.cross;
                p11.Enabled = false;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }

        }

        private void p12_Click(object sender, EventArgs e)
        {
            P[0, 1] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p12.Image = Resources.cross;
                p12.Enabled = false;
                timer = 0;
                two = 1;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }
        }

        private void p13_Click(object sender, EventArgs e)
        {
            P[0, 2] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p13.Image = Resources.cross;
                p13.Enabled = false;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }
        }

        private void p21_Click(object sender, EventArgs e)
        {
            P[1, 0] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p21.Image = Resources.cross;
                p21.Enabled = false;
                timer = 0;
                four = 1;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }
        }

        private void p22_Click(object sender, EventArgs e)
        {
            P[1, 1] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p22.Image = Resources.cross;
                p22.Enabled = false;
                five = 1;
                timer = 0;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }
        }

        private void p23_Click(object sender, EventArgs e)
        {
            P[1, 2] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p23.Image = Resources.cross;
                p23.Enabled = false;
                six = 1;
                timer = 0;
                turn = -1;
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
            if (human == false && turn == 1)
            {
                bot_v2();
            }
        }

        private void p31_Click(object sender, EventArgs e)
        {
            P[2, 0] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p31.Image = Resources.cross;
                p31.Enabled = false;
                timer = 0;
                seven = 1;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }
        }

        private void p32_Click(object sender, EventArgs e)
        {
            P[2, 1] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p32.Image = Resources.cross;
                p32.Enabled = false;
                eight = 1;
                timer = 0;
                turn = -1;
            }
            else if (turn == -1)
            {
                p32.Image = Resources.zero;
                turn = 1;
                eight = 0;
                timer = 0;
                p32.Enabled = false;
            }
            wins();
            if ( turn == 1)
            {
                bot_v2();
            }
        }

        private void p33_Click(object sender, EventArgs e)
        {
            P[2, 2] = turn;
            pictureBox10.BorderStyle = BorderStyle.None;
            pictureBox11.BorderStyle = BorderStyle.None;
            if (turn == 1)
            {
                p33.Image = Resources.cross;
                p33.Enabled = false;
                timer = 0;
                nine = 1;
                turn = -1;
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
            if (turn == 1)
            {
                bot_v2();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (language == 0)
            {
                if (normal_style == true)
                    pictureBox3.Image = Resources.eng_ru;
                else if (jedi_style == true)
                    pictureBox3.Image = Resources.eng_ru_jedi_style;
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
                if(normal_style == true)
                    pictureBox3.Image = Resources.ru_eng;
                else if(jedi_style == true)
                    pictureBox3.Image = Resources.ru_eng_jedi_style;
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
                if (normal_style == true)
                    button3.Image = Resources.Collapse_Arrow_20px;
                else if (jedi_style == true)
                    button3.Image = Resources.Collapse_Arrow_20px_jedi_style;
                style.Height += 20;
                if (style.Size == style.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                if (normal_style == true)
                    button3.Image = Resources.Expand_Arrow_20px;
                else if (jedi_style == true)
                    button3.Image = Resources.Expand_Arrow_20px_jedi_style;
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    P[i, j] = 0;
                }
            }
            another_timer = another_timer + 1;
            if (another_timer == 4 && check_win_or_not == false)
            {
                winner_zero = 0;
                winner_cross = 0;
                check_on_wins = 0;
                another_timer = 0;
                timer = 0;
                congratulation.Text = "";
                Battlefield.Show();
                timer6.Stop();
                button10_Click(sender, e);
            }
            else if(another_timer == 4 && check_win_or_not == true)
            {

                another_timer = 0;
                timer = 0;
                timer4.Start();
                start_battle_menu();
                gameScreen.BringToFront();
                timer6.Stop();
                check_win_or_not = false;
                Battlefield.Show();
            }
        }

        private void player1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            normal_style = true;
            jedi_style = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string sPath = Path.GetFileName("[v-s.mobi]Вступительные+Титры+к+Звездным+войнам+(with+English+subtitles)+HD+1080p.mp4");
            axWindowsMediaPlayer1.URL = sPath;
            jedi_style = true;
            normal_style = false;
            axWindowsMediaPlayer1.BringToFront();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = true;
            style.BringToFront();
            sound.BringToFront();
            timer1.Stop();
            this.button1.BackgroundImage = Resources.Туман;
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button11.BackgroundImage = Resources.Туман;
            this.button11.BackgroundImageLayout = ImageLayout.Stretch;
            this.button6.BackgroundImage = Resources.Туман;
            this.button6.BackgroundImageLayout = ImageLayout.Stretch;
            this.button7.BackgroundImage = Resources.Туман;
            this.button7.BackgroundImageLayout = ImageLayout.Stretch;
            this.button3.BackColor = Color.White;
            this.startMenu.BackColor = System.Drawing.Color.Transparent;
            this.BackColor = Color.Black;
            this.button1.ForeColor = Color.Black;
            this.button11.ForeColor = Color.Black;
            this.button6.ForeColor = Color.Black;
            this.button7.ForeColor = Color.Black;
            this.button3.ForeColor = Color.Black;
            this.button3.Image = Resources.Expand_Arrow_20px_jedi_style;
            this.button8.ForeColor = Color.White;
            this.button9.ForeColor = Color.White;
            this.button4.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.groupBox2.ForeColor = Color.White;
            this.groupBox1.ForeColor = Color.White;
            this.groupBox3.ForeColor = Color.White;
            this.radioButton1.ForeColor = Color.White;
            this.radioButton2.ForeColor = Color.White;
            this.radioButton3.ForeColor = Color.White;
            this.People.ForeColor = Color.White;
            this.Bot.ForeColor = Color.White;
            this.pictureBox15.Image = Resources._28Ih;
            this.pictureBox14.Image = Resources._12193865426;
            button3_Click_1(sender, e);
            pictureBox13.Image = Resources.multifandom_ru_1597;
            pictureBox4.Image = Resources.Справка_jedi_style;
            pictureBox2.Image = Resources.volume_jedi_style;
            pictureBox1.Image = Resources.fullscreen_jedi_style;
            if (language == 0)
            {
                pictureBox3.Image = Resources.ru_eng_jedi_style;
            }
            else
                pictureBox3.Image = Resources.eng_ru_jedi_style;
            pictureBox12.Hide();
            style.BringToFront();
            sound.BringToFront();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                this.axWindowsMediaPlayer1.close();
                startMenu.BringToFront();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (jedi_style == true)
            {
                if (e.KeyData == Keys.Escape)
                {
                    this.axWindowsMediaPlayer1.close();
                    startMenu.BringToFront();
                }
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        { }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        { }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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
            else if (turn == -1 && side == 1)
            {
                pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            }
            else if(turn == -1 && side == 2)
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
