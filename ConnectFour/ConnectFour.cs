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
    public partial class ConnectFour : Form
    {   
        Button[,] btn = new Button[7, 6]; //2d array of buttons for grid
        public ConnectFour()
        {
            InitializeComponent();

            //initalise grid
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    btn[x, y] = new Button();

                    //style
                    btn[x, y].SetBounds(60 * x, 60 * y, 50, 50); //sets size
                    btn[x, y].BackColor = Color.DarkBlue;
                    btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1)); //adds co-ordinates as text
                    btn[x, y].Font = new Font(Font.Name, 1, Font.Style); //makes the co-ordinate text hidden
                    btn[x, y].ForeColor = Color.DarkBlue; //makes the co-ordinate text hidden
                    btn[x, y].FlatStyle = FlatStyle.Flat;

                    //offsets the grid from the edges of the form
                    btn[x, y].Top += 120;
                    btn[x, y].Left += 60;

                    //event handlers
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    btn[x, y].MouseEnter += new EventHandler(this.btnEvent_MouseEnter);
                    btn[x, y].MouseLeave += new EventHandler(this.btnEvent_MouseLeave);


                    Controls.Add(btn[x, y]);
                }

                //changes available moves to a different colour
                btn[x, 5].BackColor = Color.Turquoise;
                btn[x, 5].ForeColor = Color.Turquoise;
            }
        }

        void btnEvent_Click(object sender, EventArgs e)
        {
           
            if (((Button)sender).BackColor == Color.BlueViolet)
            {
                //change button color


                //make button above button pressed change colour to show a new available move
                string grdXY = ((Button)sender).Text;
                string[] splitGrid = grdXY.Split(',');
                int toChangeX = (Convert.ToInt32(splitGrid[0])) - 1;
                int toChangeY = (Convert.ToInt32(splitGrid[1])) - 1;
                Console.WriteLine(toChangeX + " " + toChangeY);
                if (toChangeY != 0)
                {
                    btn[(toChangeX), (toChangeY - 1)].BackColor = Color.Turquoise;
                    btn[(toChangeX), (toChangeY - 1)].ForeColor = Color.Turquoise;
                }
            }
            
        }

        void btnEvent_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Turquoise)
            {
                ((Button)sender).BackColor = Color.BlueViolet;
                ((Button)sender).ForeColor = Color.BlueViolet;
            }
        }

        void btnEvent_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.BlueViolet)
            {
                ((Button)sender).BackColor = Color.Turquoise;
                ((Button)sender).ForeColor = Color.Turquoise;
            }
        }

        private void ConnectFour_Load(object sender, EventArgs e)
        {

        }
    }
}
