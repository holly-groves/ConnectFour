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
    public partial class DifficultyOptions : Form
    {
        public DifficultyOptions()
        {
            InitializeComponent();
            easy.Click += new EventHandler(this.Easy_Click);
            hard.Click += new EventHandler(this.Hard_Click);
            previousOption.Click += new EventHandler(this.PreviousOption_Click);
            mainMenu.Click += new EventHandler(this.MainMenu_Click);
            exitGame.Click += new EventHandler(this.ExitGame_Click);
            Controls.Add(easy);
            Controls.Add(hard);
            Controls.Add(previousOption);
            Controls.Add(mainMenu);
            Controls.Add(exitGame);
            //responsible for the effect on the button as the mouse enters and leaves
            easy.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            easy.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            previousOption.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            previousOption.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            previousOption.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            previousOption.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            mainMenu.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            mainMenu.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);
            exitGame.MouseEnter += new EventHandler(this.BtnEvent_MouseEnter);
            exitGame.MouseLeave += new EventHandler(this.BtnEvent_MouseLeave);

        }


        //this redirects to the game page
        private void Easy_Click(object sender, EventArgs e)
        {
            //ConnectFourVsComputerEasy game = new ConnectFourVsComputerEasy();
            //game.Show();
            //this.Hide();
        }
        

        //this redirects to the game page for hard game vs computer
        private void Hard_Click(object sender, EventArgs e)
        {
            //ConnectFourVsComputerHard game = new ConnectFourVsComputerHard();
            //game.Show();
            //this.Hide();
        }


        //Option to returns back to the previous option
        private void PreviousOption_Click(object sender, EventArgs e)
        {
            OpponentOptions options = new OpponentOptions();
            options.Show();
            this.Hide();
        }


        //this returns to the start page
        private void MainMenu_Click(object sender, EventArgs e)
        {
            ConnectFourStart start = new ConnectFourStart();
            start.Show();
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

        //displays tooltip for the hard button as the mouse enters
        // void BtnEvent_MouseEnter1(object sender, EventArgs e)
        // {
        //     int y = Grid.GetColumn((Button)sender);
        //     int x = Grid.GetRow((Button)sender);
        //     ToolTip.Show("Hard game has a default time interval of 10 secs",btn[x,y]);
        // }

        //this loads the form
        private void DifficultyOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
