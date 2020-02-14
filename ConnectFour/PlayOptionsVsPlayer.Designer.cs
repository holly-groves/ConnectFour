namespace ConnectFour
{
    partial class PlayOptionsVsPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayOptionsVsPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.exitGame = new System.Windows.Forms.Button();
            this.previousOption = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.noTimer = new System.Windows.Forms.Button();
            this.withTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Options";
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.Aqua;
            this.exitGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitGame.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(128, 432);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(270, 105);
            this.exitGame.TabIndex = 18;
            this.exitGame.Text = "Exit Game";
            this.exitGame.UseVisualStyleBackColor = false;
            // 
            // previousOption
            // 
            this.previousOption.BackColor = System.Drawing.Color.Aqua;
            this.previousOption.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousOption.Location = new System.Drawing.Point(10, 321);
            this.previousOption.Name = "previousOption";
            this.previousOption.Size = new System.Drawing.Size(270, 105);
            this.previousOption.TabIndex = 17;
            this.previousOption.Text = "Previous Option";
            this.previousOption.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Aqua;
            this.mainMenu.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(286, 321);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(270, 105);
            this.mainMenu.TabIndex = 16;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            // 
            // noTimer
            // 
            this.noTimer.BackColor = System.Drawing.Color.Aqua;
            this.noTimer.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTimer.Location = new System.Drawing.Point(128, 210);
            this.noTimer.Name = "noTimer";
            this.noTimer.Size = new System.Drawing.Size(270, 105);
            this.noTimer.TabIndex = 15;
            this.noTimer.Text = "Without Timer";
            this.noTimer.UseVisualStyleBackColor = false;
            // 
            // withTimer
            // 
            this.withTimer.BackColor = System.Drawing.Color.Aqua;
            this.withTimer.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withTimer.Location = new System.Drawing.Point(128, 99);
            this.withTimer.Name = "withTimer";
            this.withTimer.Size = new System.Drawing.Size(270, 105);
            this.withTimer.TabIndex = 14;
            this.withTimer.Text = "With Timer";
            this.withTimer.UseVisualStyleBackColor = false;
            // 
            // PlayOptionsVsPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(564, 591);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.previousOption);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.noTimer);
            this.Controls.Add(this.withTimer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 630);
            this.MinimumSize = new System.Drawing.Size(580, 630);
            this.Name = "PlayOptionsVsPlayer";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.PlayOptionsVsPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button previousOption;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button noTimer;
        private System.Windows.Forms.Button withTimer;
    }
}