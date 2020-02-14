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
    public partial class GameInstructions : Form
    {
        public GameInstructions()
        {
            InitializeComponent();
            mainMenu.Click += new EventHandler(this.MainMenu_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            Controls.Add(mainMenu);
            Controls.Add(exitGame);
            //responsible for the effect on the button as the mouse enters and leaves
            mainMenu.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            exitGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
        }

        //this redirects the window to the start page
        private void MainMenu_Click(object sender, EventArgs e)
        {
            ConnectFourStart startPage = new ConnectFourStart();
            startPage.Show();
            this.Hide();
        }

        //this closes the window
        private void ExitGame_Click(object sender, EventArgs e)
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
            ((Button)sender).BackColor = Color.Aqua;
            ((Button)sender).ForeColor = Color.Black;
        }
        private void GameInstructions_Load(object sender, EventArgs e)
        {

        }

        
    }
}
