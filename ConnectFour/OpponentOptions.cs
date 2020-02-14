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
    public partial class OpponentOptions : Form
    {
        public OpponentOptions()
        {
            InitializeComponent();
            vsPlayer.Click += new EventHandler(this.VsPlayer_Click);
            vsComputer.Click += new EventHandler(this.VsComputer_Click);
            mainMenu.Click += new EventHandler(this.MainMenu_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            Controls.Add(vsPlayer);
            Controls.Add(vsComputer);
            Controls.Add(mainMenu);
            Controls.Add(exitGame);
            //responsible for the effect on the button as the mouse enters and leaves
            vsPlayer.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            vsPlayer.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            vsComputer.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            vsComputer.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            mainMenu.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            mainMenu.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            exitGame.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            exitGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
        }

        //this redirects to the play options vs player
        void VsPlayer_Click(object sender, EventArgs e)
        {
            PlayOptionsVsPlayer options = new PlayOptionsVsPlayer();
            options.Show();
            this.Hide();
        }

        //this redirects to the difficulty options for vs computer
        void VsComputer_Click(object sender, EventArgs e)
        {
            DifficultyOptions option = new DifficultyOptions();
            option.Show();
            this.Hide();
        }

        //this returns the window to the start page
        void MainMenu_Click(object sender, EventArgs e)
        {
            ConnectFourStart startPage = new ConnectFourStart();
            startPage.Show();
            this.Hide();
        }

        //to close the window
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

        //this loads the form
        private void OpponentOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
