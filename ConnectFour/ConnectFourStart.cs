using System;
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
    public partial class ConnectFourStart : Form
    {
        public ConnectFourStart()
        {
            InitializeComponent();

            startGame.Click += new EventHandler(this.StartGame_Click);
            gameInstructions.Click += new EventHandler(this.GameInstructions_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            Controls.Add(startGame);
            Controls.Add(gameInstructions);
            Controls.Add(exitGame);
            //responsible for the effect on the button as the mouse enters and leaves
            startGame.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            startGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            gameInstructions.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            gameInstructions.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            exitGame.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            exitGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
        }



        //this redirects to the opponent form
        private void StartGame_Click(object sender, EventArgs e)
        {
            OpponentOptions options = new OpponentOptions();
            options.Show();
            this.Hide();
        }


        //this redirects to the instructions page
        private void GameInstructions_Click(object sender, EventArgs e)
        {
            GameInstructions instructions = new GameInstructions();
            instructions.Show();
            this.Hide();
        }


        //this redirects to the wins page displaying the colour with the most wins
        void BtnEvent_Click2(object sender, EventArgs e)
        {
            //MostWins wins = new MostWins();
            //wins.Show();
            //this.Hide();
        }

        //to close the window
        private void ExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        //changes the colour of the button and it's text as the mouse enters
        void BtnEvent_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DarkBlue;
            ((Button)sender).ForeColor = Color.White;
        }

        //changes the colour of the button and it's text as the mouse leaves
        void BtnEvent_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aqua;
            ((Button)sender).ForeColor = Color.Black;
        }

        //loads the form
        private void ConnectFourStart_Load(object sender, EventArgs e)
        {

        }
    }
}
