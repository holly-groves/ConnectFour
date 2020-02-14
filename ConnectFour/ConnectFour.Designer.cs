namespace ConnectFour
{
    partial class ConnectFour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectFour));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_Computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(403, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Connect Four";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Aqua;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(28, 613);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(219, 53);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(569, 757);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(278, 635);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(135, 31);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "Red Turn";
            // 
            // lblYel
            // 
            this.lblYel.AutoSize = true;
            this.lblYel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYel.ForeColor = System.Drawing.Color.Yellow;
            this.lblYel.Location = new System.Drawing.Point(261, 604);
            this.lblYel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYel.Name = "lblYel";
            this.lblYel.Size = new System.Drawing.Size(168, 31);
            this.lblYel.TabIndex = 3;
            this.lblYel.Text = "Yellow Turn";
            this.lblYel.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aqua;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(451, 610);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_Computer
            // 
            this.btn_Computer.BackColor = System.Drawing.Color.Aqua;
            this.btn_Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_Computer.Location = new System.Drawing.Point(451, 41);
            this.btn_Computer.Name = "btn_Computer";
            this.btn_Computer.Size = new System.Drawing.Size(219, 53);
            this.btn_Computer.TabIndex = 5;
            this.btn_Computer.Text = "Computer Move";
            this.btn_Computer.UseVisualStyleBackColor = false;
            this.btn_Computer.Click += new System.EventHandler(this.btn_Computer_Click);
            // 
            // ConnectFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.btn_Computer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblYel);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 728);
            this.MinimumSize = new System.Drawing.Size(722, 728);
            this.Name = "ConnectFour";
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.ConnectFour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlayAgain;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_Computer;
    }
}

