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
    public partial class IntervalOptionsVsComputer : Form
    {
        Button[,] btn = new Button[1, 7];       // 2D array of buttons

        public IntervalOptionsVsComputer()
        {
            InitializeComponent();
            for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                {
                    btn[x, y] = new Button();
                    //sets the dimensions of the button
                    btn[x, y].SetBounds(100 * x, 100 * y, 230, 90);
                    //sets button colour
                    btn[x, y].BackColor = Color.LightBlue;
                    //assigns the text for the buttons and their coresponding event handlers
                    if (y == 0)
                    {
                        btn[x, y].Text = "5 secs";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 1)
                    {
                        btn[x, y].Text = "10 secs";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 2)
                    {
                        btn[x, y].Text = "30 secs";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 3)
                    {
                        btn[x, y].Text = "1 min";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click);
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 4)
                    {
                        btn[x, y].Text = "Previous Option";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click4);
                        btn[x, y].Left -= 100;
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 5)
                    {
                        btn[x, y].Text = "Main Menu";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click5);
                        btn[x, y].Top -= 100;
                        btn[x, y].Left += 140;
                        Controls.Add(btn[x, y]);
                    }
                    else if (y == 6)
                    {
                        btn[x, y].Text = "Exit Game";
                        btn[x, y].Click += new EventHandler(this.BtnEvent_Click6);
                        btn[x, y].Top -= 100;
                        Controls.Add(btn[x, y]);
                    }

                    //sets button text font
                    btn[x, y].Font = new Font("Showcard Gothic", 20, FontStyle.Bold);
                    //sets button positioning
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    btn[x, y].Top += 100;
                    btn[x, y].Left += 140;
                    //responsible for the effect on the button as the mouse enters and leaves
                    btn[x, y].MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
                    btn[x, y].MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
                }
            }
        }

        //this sets the time intervals based on the buttons clicked
        void BtnEvent_Click(object sender, EventArgs e)
        {
            //ConnectFourTimedVsComputer game = new ConnectFourTimedVsComputer();
            //this splits the text within the button
            string time = ((Button)sender).Text;
            string[] split = time.Split(',');
            int interval = (Convert.ToInt32(split[0]));

            //this sets the interval to be used in the timed game
            if (interval != 1)
            {
                //game = new ConnectFourTimedVsComputer(interval*1000);
                //game.Show();
                //this.Hide();
            }
            else
            {
                //game = new ConnectFourTimedVsComputer(interval*60*1000);
                //game.Show();
                //this.Hide();
            }
        }

        //Option to returns back to the previous option
        void BtnEvent_Click4(object sender, EventArgs e)
        {
            DifficultyOptions options = new DifficultyOptions();
            options.Show();
            this.Hide();
        }

        //this redirects the window to the start page
        void BtnEvent_Click5(object sender, EventArgs e)
        {
            ConnectFourStart start = new ConnectFourStart();
            start.Show();
            this.Hide();
        }

        //this closes the window
        void BtnEvent_Click6(object sender, EventArgs e)
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
        private void IntervalOptionsVsComputer_Load(object sender, EventArgs e)
        {

        }
    }
}
