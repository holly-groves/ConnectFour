namespace ConnectFour
{
    partial class ConnectFourStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectFourStart));
            this.label1 = new System.Windows.Forms.Label();
            this.exitGame = new System.Windows.Forms.Button();
            this.gameInstructions = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect Four";
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.Color.Aqua;
            this.exitGame.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGame.Location = new System.Drawing.Point(130, 339);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(270, 105);
            this.exitGame.TabIndex = 6;
            this.exitGame.Text = "Exit Game";
            this.exitGame.UseVisualStyleBackColor = false;
            // 
            // gameInstructions
            // 
            this.gameInstructions.BackColor = System.Drawing.Color.Aqua;
            this.gameInstructions.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInstructions.Location = new System.Drawing.Point(130, 228);
            this.gameInstructions.Name = "gameInstructions";
            this.gameInstructions.Size = new System.Drawing.Size(270, 105);
            this.gameInstructions.TabIndex = 5;
            this.gameInstructions.Text = "Game Instructions";
            this.gameInstructions.UseVisualStyleBackColor = false;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Aqua;
            this.startGame.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(130, 117);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(270, 105);
            this.startGame.TabIndex = 4;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            // 
            // ConnectFourStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(530, 561);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.gameInstructions);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectFourStart";
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.ConnectFourStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Button gameInstructions;
        private System.Windows.Forms.Button startGame;
    }
}