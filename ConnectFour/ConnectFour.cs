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
    public partial class ConnectFour : Form
    {
        Button[,] btn = new Button[7, 6];
        public ConnectFour()
        {
            InitializeComponent();
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(60 * x, 60 * y, 50, 50);
                    btn[x, y].BackColor = Color.DarkBlue;
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    Controls.Add(btn[x, y]);
                    btn[x, y].Top += 120;
                    btn[x, y].Left += 60;
                }
                btn[x, 0].Padding = new Padding(0, 100, 0, 0);
                
            }
        }

        void btnEvent_Click(object sender, EventArgs e)
        {

        }

        private void ConnectFour_Load(object sender, EventArgs e)
        {

        }
    }
}
