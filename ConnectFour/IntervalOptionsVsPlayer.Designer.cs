namespace ConnectFour
{
    partial class IntervalOptionsVsPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntervalOptionsVsPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.exitGame = new System.Windows.Forms.Button();
            this.previousOption = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.interval2 = new System.Windows.Forms.Button();
            this.interval1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervals";
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.Aqua;
            this.exitGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitGame.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(125, 430);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(270, 105);
            this.exitGame.TabIndex = 13;
            this.exitGame.Text = "Exit Game";
            this.exitGame.UseVisualStyleBackColor = false;
            // 
            // previousOption
            // 
            this.previousOption.BackColor = System.Drawing.Color.Aqua;
            this.previousOption.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousOption.Location = new System.Drawing.Point(7, 319);
            this.previousOption.Name = "previousOption";
            this.previousOption.Size = new System.Drawing.Size(270, 105);
            this.previousOption.TabIndex = 12;
            this.previousOption.Text = "Previous Option";
            this.previousOption.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Aqua;
            this.mainMenu.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(283, 319);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(270, 105);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            // 
            // interval2
            // 
            this.interval2.BackColor = System.Drawing.Color.Aqua;
            this.interval2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interval2.Location = new System.Drawing.Point(125, 208);
            this.interval2.Name = "interval2";
            this.interval2.Size = new System.Drawing.Size(270, 105);
            this.interval2.TabIndex = 10;
            this.interval2.Text = "30 secs";
            this.interval2.UseVisualStyleBackColor = false;
            this.interval2.Click += new System.EventHandler(this.Interval2_Click);
            // 
            // interval1
            // 
            this.interval1.BackColor = System.Drawing.Color.Aqua;
            this.interval1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interval1.Location = new System.Drawing.Point(125, 97);
            this.interval1.Name = "interval1";
            this.interval1.Size = new System.Drawing.Size(270, 105);
            this.interval1.TabIndex = 9;
            this.interval1.Text = "10 secs";
            this.interval1.UseVisualStyleBackColor = false;
            this.interval1.Click += new System.EventHandler(this.Interval1_Click);
            // 
            // IntervalOptionsVsPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(564, 591);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.previousOption);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.interval2);
            this.Controls.Add(this.interval1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 630);
            this.MinimumSize = new System.Drawing.Size(580, 630);
            this.Name = "IntervalOptionsVsPlayer";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.IntervalOptionsVsPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button previousOption;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button interval2;
        private System.Windows.Forms.Button interval1;
    }
}