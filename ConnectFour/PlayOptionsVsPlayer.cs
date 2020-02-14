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
    public partial class PlayOptionsVsPlayer : Form
    {
        public PlayOptionsVsPlayer()
        {
            InitializeComponent();
            withTimer.Click += new EventHandler(this.WithTimer_Click);
            noTimer.Click += new EventHandler(this.NoTimer_Click);
            mainMenu.Click += new EventHandler(this.MainMenu_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            previousOption.Click += new EventHandler(this.PreviousOption_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            Controls.Add(withTimer);
            Controls.Add(noTimer);
            Controls.Add(mainMenu);
            Controls.Add(exitGame);
            Controls.Add(previousOption);
            //responsible for the effect on the button as the mouse enters and leaves
            withTimer.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            withTimer.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            noTimer.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            noTimer.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            previousOption.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            previousOption.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            mainMenu.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            mainMenu.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            exitGame.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            exitGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
        }

        //this redirects to the interval options
        private void WithTimer_Click(object sender, EventArgs e)
        {
            IntervalOptionsVsPlayer intervals = new IntervalOptionsVsPlayer();
            intervals.Show();
            this.Hide();
        }

        //this redirects the window to the game window
        private void NoTimer_Click(object sender, EventArgs e)
        {
            ConnectFour game = new ConnectFour();
            game.Show();
            this.Hide();
        }

        //Option to returns back to the previous option
        void PreviousOption_Click(object sender, EventArgs e)
        {
            OpponentOptions options = new OpponentOptions();
            options.Show();
            this.Hide();
        }

        //this redirects the window to the start page
        void MainMenu_Click(object sender, EventArgs e)
        {
            ConnectFourStart start = new ConnectFourStart();
            start.Show();
            this.Hide();
        }

        //this closes the window
        void ExitGame_Click(object sender, EventArgs e)
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

        //this loads the window
        private void PlayOptionsVsPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
