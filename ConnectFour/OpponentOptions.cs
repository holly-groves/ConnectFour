﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class OpponentOptions : Form
    {
        Button[,] btn = new Button[1, 4];   // 2D array of buttons
        public OpponentOptions()
        {
            InitializeComponent();
            for (int x = 0; x < btn.GetLength(0); x++)            // Loop for x
            {
                for (int y = 0; y < btn.GetLength(1); y++)    // Loop for y
                {
                    btn[x, y] = new Button();
                    //sets the dimensions of the button
                    btn[x, y].SetBounds(100 * x, 100 * y, 230, 90);
                    //sets button colour
                    btn[x, y].BackColor = Color.LightBlue;
                    //assigns the text for the buttons and their coresponding event handlers
                    if (y == 0)
                    {
                        btn[x, y].Text = "Vs Player";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 1)
                    {
                        btn[x, y].Text = "Vs Computer";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click1);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 2)
                    {
                        btn[x, y].Text = "Main Menu";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click2);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 3)
                    {
                        btn[x, y].Text = "Exit Game";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click3);
                        Controls.Add(btn[x, y]);
                    }

                    //sets button text font
                    btn[x, y].Font = new Font("Showcard Gothic", 20, FontStyle.Bold);
                    //sets button positioning
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    btn[x, y].Top += 120;
                    btn[x, y].Left += 140;
                    //responsible for the effect on the button as the mouse enters and leaves
                    btn[x, y].MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
                    btn[x, y].MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
                }
            }
        }

        //this redirects to the play options vs player
        void BtnEvent_Click(object sender, EventArgs e)
        {
            PlayOptionsVsPlayer options = new PlayOptionsVsPlayer();
            options.Show();
            this.Hide();
        }

        //this redirects to the difficulty options for vs computer
        void BtnEvent_Click1(object sender, EventArgs e)
        {
            DifficultyOptions option = new DifficultyOptions();
            option.Show();
            this.Hide();
        }

        //this returns the window to the start page
        void BtnEvent_Click2(object sender, EventArgs e)
        {
            ConnectFourStart startPage = new ConnectFourStart();
            startPage.Show();
            this.Hide();
        }

        //this closes the window
        void BtnEvent_Click3(object sender, EventArgs e)
        {
            Close();
        }

        //changes the colour of the button and button text as the mouse enters
        void BtnEvent_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DarkBlue;
            ((Button)sender).ForeColor = Color.White;
        }

        //changes the colour of the button and button text as the mouse leaves
        void BtnEvent_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightBlue;
            ((Button)sender).ForeColor = Color.Black;
        }

        //this loads the form
        private void OpponentOptions_Load(object sender, EventArgs e)
        {

        }
    }
}