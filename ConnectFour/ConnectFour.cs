using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media; //to allow soundfile to be played

namespace ConnectFour
{
    public partial class ConnectFour : Form
    {

        Button[,] btn = new Button[7, 6]; //2d array of Buttons for grid
        int filledCollumns; //to keep track moves available incase the board is filled up with no winner



        //boolean variable to be accesed throughout to determine which players turn it is
        bool redTurn;
 
        public ConnectFour()
        {
            InitializeComponent();

            plays background music
            SoundPlayer player = new SoundPlayer("sound.midi");
            player.Play();

            filledCollumns = 0;
            redTurn = true;
               
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

        //function to change the colour of a valid button, only to be called after a button is clicked
        void colourChange(object sender)
        {
            // if (((Button)sender).BackColor == Color.BlueViolet) //if it is a valid move in the game context
            //{
            if (redTurn == true) //when it is red players turn, Button is changed to red
            {
                ((Button)sender).BackColor = Color.Red;
                ((Button)sender).ForeColor = Color.Red;
            }

            else //if it is yellow players turn then change Button to yellow
            {
                ((Button)sender).BackColor = Color.Yellow;
                ((Button)sender).ForeColor = Color.Yellow;
            }
            winChecker(((Button)sender));
            redTurn = !redTurn; //changes to the other players turn  
                                //   }
        }
        //plays a sound for the win
        SoundPlayer winSong;
        void redWin()//Displays a message informing that red player has won and then closes the game
        {
            DialogResult redW;
            //plays a win sound
            winSong = new SoundPlayer("WinSoundEffect.wav");
            winSong.Play();
            redW = MessageBox.Show("Congratulations Red Player has won the game!", "Red Win!", MessageBoxButtons.OK, MessageBoxIcon.None);
            //stops the sound
            winSong.Stop();
            Close();
        }
        void yellowWin() //Displays a message informing that yellow has won and then closes the game
        {
            DialogResult yellowW;
            //plays a win sound
            winSong = new SoundPlayer("WinSoundEffect.mp3");
            winSong.Play();
            yellowW = MessageBox.Show("Congratulations Yellow Player has won the game!", "Yellow Win!", MessageBoxButtons.OK, MessageBoxIcon.None);
            //stops the sound
            winSong.Stop();
            Close();
        }


        void winChecker(object sender) //checks entire btn grid for four red or yellow buttons in a row
        {
            for (int x = 0; x < 4; x++)//checks for a horizontal 4 in a row
            {
                for (int y = 0; y < 6; y++)
                {
                    if (btn[x, y].BackColor == Color.Red && btn[x + 1, y].BackColor == Color.Red && btn[x + 2, y].BackColor == Color.Red && btn[x + 3, y].BackColor == Color.Red)
                    {
                        redWin();
                    }
                    else if (btn[x, y].BackColor == Color.Yellow && btn[x + 1, y].BackColor == Color.Yellow && btn[x + 2, y].BackColor == Color.Yellow && btn[x + 3, y].BackColor == Color.Yellow)
                    {
                        yellowWin();
                    } 
                }
            }//HORIZONTAL CHECK END

            for (int x = 0; x < 7; x++) //checks for a vertical four in a row
            {
                for (int y = 0; y < 3; y++)
                {
                    if (btn[x, y].BackColor == Color.Red && btn[x, y + 1].BackColor == Color.Red && btn[x, y + 2].BackColor == Color.Red && btn[x, y + 3].BackColor == Color.Red)
                    {
                        redWin();
                    }
                    else if (btn[x, y].BackColor == Color.Yellow && btn[x, y + 1].BackColor == Color.Yellow && btn[x, y + 2].BackColor == Color.Yellow && btn[x, y + 3].BackColor == Color.Yellow)
                    {
                        yellowWin();
                    }  
                }
            }//vertical check end

            for (int x = 0; x < 4; x++)//checks for a win sloping upwards
            {
                for (int y = 5; y > 2; y--)
                {
                    if (btn[x, y].BackColor == Color.Red && btn[x + 1, y - 1].BackColor == Color.Red && btn[x + 2, y - 2].BackColor == Color.Red && btn[x + 3, y - 3].BackColor == Color.Red)
                    {
                        redWin();
                    }
                    else if (btn[x, y].BackColor == Color.Yellow && btn[x + 1, y - 1].BackColor == Color.Yellow && btn[x + 2, y - 2].BackColor == Color.Yellow && btn[x + 3, y - 3].BackColor == Color.Yellow)
                    {
                        yellowWin();
                    }
                }
            }//diagonal up end

            for (int x = 0; x < 4; x++) //checks for a four in a row sloping downward
            {
                for (int y = 0; y < 3; y++)
                {
                    if (btn[x, y].BackColor == Color.Red && btn[x + 1, y + 1].BackColor == Color.Red && btn[x + 2, y + 2].BackColor == Color.Red && btn[x + 3, y + 3].BackColor == Color.Red)
                    {
                        redWin();
                    }
                    else if (btn[x, y].BackColor == Color.Yellow && btn[x + 1, y + 1].BackColor == Color.Yellow && btn[x + 2, y + 2].BackColor == Color.Yellow && btn[x + 3, y + 3].BackColor == Color.Yellow)
                    {
                        yellowWin();
                    }
                }
            }//diagonal down end
        }












        void btnEvent_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.BlueViolet || ((Button)sender).BackColor == Color.PaleVioletRed || ((Button)sender).BackColor == Color.PaleGoldenrod)
            {
                //Button colour is changed to appropriate colour and turn is changed
                colourChange((Button)sender);
                
                //make Button above Button pressed change colour to show a new available move
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
                else //collumn where player placed a piece is now full
                {
                    filledCollumns++;
                    if (filledCollumns == 7)  //all collumns are filled
                    {
                        //end game with no winner
                        DialogResult result;
                        result = MessageBox.Show("No valid moves left, the game is tied.", "No Moves Left", MessageBoxButtons.OK, MessageBoxIcon.None);
                        btnPlayAgain.Visible = true; //makes play again button visible
                        
                    }
                }
            }
        }

        void btnEvent_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Turquoise)
            {
                if (redTurn == true) //if it is the red players turn, when the mouse hovers over a valid Button it will preview red
                {
                    ((Button)sender).BackColor = Color.PaleVioletRed;
                    ((Button)sender).ForeColor = Color.PaleVioletRed;
                }
                else //if it is the yellow players turn, when the mouse hovers over a valid Button it will preview yellow
                {
                    ((Button)sender).BackColor = Color.PaleGoldenrod;
                    ((Button)sender).ForeColor = Color.PaleGoldenrod;
                }
            }
        }

        void btnEvent_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.BlueViolet)
            {
                ((Button)sender).BackColor = Color.Turquoise;
                ((Button)sender).ForeColor = Color.Turquoise;
            }
            if (((Button)sender).BackColor == Color.PaleVioletRed)
            {
                ((Button)sender).BackColor = Color.Turquoise;
                ((Button)sender).ForeColor = Color.Turquoise;
            }
            if (((Button)sender).BackColor == Color.PaleGoldenrod)
            {     
                ((Button)sender).BackColor = Color.Turquoise;
                ((Button)sender).ForeColor = Color.Turquoise;
            }
        }


        private void ConnectFour_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //reset game variables
            btnPlayAgain.Visible = false;
            filledCollumns = 0;
            redTurn = true;

            //reset the button colours
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    btn[x, y].BackColor = Color.DarkBlue;
                    btn[x, y].ForeColor = Color.DarkBlue; //makes the co-ordinate text hidden
                }
                //changes available moves to a different colour
                btn[x, 5].BackColor = Color.Turquoise;
                btn[x, 5].ForeColor = Color.Turquoise;
            }
        }

        
    }
}
