namespace ConnectFour
{
    partial class OpponentOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpponentOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.exitGame = new System.Windows.Forms.Button();
            this.vsComputer = new System.Windows.Forms.Button();
            this.vsPlayer = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opponent";
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.Aqua;
            this.exitGame.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(121, 432);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(270, 105);
            this.exitGame.TabIndex = 9;
            this.exitGame.Text = "Exit Game";
            this.exitGame.UseVisualStyleBackColor = false;
            // 
            // vsComputer
            // 
            this.vsComputer.BackColor = System.Drawing.Color.Aqua;
            this.vsComputer.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsComputer.Location = new System.Drawing.Point(121, 207);
            this.vsComputer.Name = "vsComputer";
            this.vsComputer.Size = new System.Drawing.Size(270, 105);
            this.vsComputer.TabIndex = 8;
            this.vsComputer.Text = "Vs Computer";
            this.vsComputer.UseVisualStyleBackColor = false;
            // 
            // vsPlayer
            // 
            this.vsPlayer.BackColor = System.Drawing.Color.Aqua;
            this.vsPlayer.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsPlayer.Location = new System.Drawing.Point(121, 96);
            this.vsPlayer.Name = "vsPlayer";
            this.vsPlayer.Size = new System.Drawing.Size(270, 105);
            this.vsPlayer.TabIndex = 7;
            this.vsPlayer.Text = "Vs Player";
            this.vsPlayer.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Aqua;
            this.mainMenu.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(121, 318);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(270, 105);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            // 
            // OpponentOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(530, 561);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.vsComputer);
            this.Controls.Add(this.vsPlayer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(546, 600);
            this.MinimumSize = new System.Drawing.Size(546, 600);
            this.Name = "OpponentOptions";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.OpponentOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button vsComputer;
        private System.Windows.Forms.Button vsPlayer;
        private System.Windows.Forms.Button mainMenu;
    }
}