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
    public partial class IntervalOptionsVsPlayer : Form
    {
        Button[,] btn = new Button[1, 7];       // 2D array of buttons
        public IntervalOptionsVsPlayer()
        {
            InitializeComponent();
            interval1.Click += new EventHandler(this.Interval1_Click);
            interval2.Click += new EventHandler(this.Interval2_Click);
            mainMenu.Click += new EventHandler(this.MainMenu_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            previousOption.Click += new EventHandler(this.PreviousOption_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            Controls.Add(interval1);
            Controls.Add(interval2);
            Controls.Add(mainMenu);
            Controls.Add(exitGame);
            Controls.Add(previousOption);
            //responsible for the effect on the button as the mouse enters and leaves
            interval2.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            interval2.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            interval1.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            interval1.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            previousOption.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            previousOption.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            mainMenu.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            mainMenu.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            exitGame.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            exitGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);

            
        }

        //this sets the time intervals based on the buttons clicked
        private void Interval1_Click(object sender, EventArgs e)
        {
            //ConnctFourTimed game = new ConnectFourTimed();
            //splits the text within the buttons
            string time = ((Button)sender).Text;
            string[] split = time.Split(',');
            int interval = (Convert.ToInt32(split[0]));
            //game = new ConnectFourTimed(interval*60*1000);
            //game.Show();
            //this.Hide();
        }

        //this sets the time intervals based on the buttons clicked
        private void Interval2_Click(object sender, EventArgs e)
        {
            //ConnctFourTimed game = new ConnectFourTimed();
            //splits the text within the buttons
            string time = ((Button)sender).Text;
            string[] split = time.Split(',');
            int interval = (Convert.ToInt32(split[0]));
            //game = new ConnectFourTimed(interval*1000);
            //game.Show();
            //this.Hide();
        }

        //Option to returns back to the previous option
        void PreviousOption_Click(object sender, EventArgs e)
        {
            PlayOptionsVsPlayer options = new PlayOptionsVsPlayer();
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

        //this loads the form
        private void IntervalOptionsVsPlayer_Load(object sender, EventArgs e)
        {

        }

        
    }
}
