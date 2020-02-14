namespace ConnectFour
{
    partial class DifficultyOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultyOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.previousOption = new System.Windows.Forms.Button();
            this.exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Aqua;
            this.mainMenu.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(288, 339);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(270, 105);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Aqua;
            this.hard.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(130, 228);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(270, 105);
            this.hard.TabIndex = 5;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Aqua;
            this.easy.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(130, 117);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(270, 105);
            this.easy.TabIndex = 4;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // previousOption
            // 
            this.previousOption.BackColor = System.Drawing.Color.Aqua;
            this.previousOption.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousOption.Location = new System.Drawing.Point(12, 339);
            this.previousOption.Name = "previousOption";
            this.previousOption.Size = new System.Drawing.Size(270, 105);
            this.previousOption.TabIndex = 7;
            this.previousOption.Text = "Previous Option";
            this.previousOption.UseVisualStyleBackColor = false;
            this.previousOption.Click += new System.EventHandler(this.PreviousOption_Click);
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.Aqua;
            this.exitGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitGame.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(130, 450);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(270, 105);
            this.exitGame.TabIndex = 8;
            this.exitGame.Text = "Exit Game";
            this.exitGame.UseVisualStyleBackColor = false;
            this.exitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // DifficultyOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(564, 611);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.previousOption);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 650);
            this.MinimumSize = new System.Drawing.Size(580, 650);
            this.Name = "DifficultyOptions";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.DifficultyOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button previousOption;
        private System.Windows.Forms.Button exitGame;
    }
}