namespace RockPaperScissorOneal
{
    partial class frmRockPaperScissors
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
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.grbPlayerGuess = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbComputerGuess = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.grbPlayerGuess.SuspendLayout();
            this.grbComputerGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Location = new System.Drawing.Point(23, 35);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(51, 17);
            this.radPlayerRock.TabIndex = 0;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            this.radPlayerRock.CheckedChanged += new System.EventHandler(this.radPlayerRock_CheckedChanged);
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Location = new System.Drawing.Point(23, 85);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(53, 17);
            this.radPlayerPaper.TabIndex = 1;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Location = new System.Drawing.Point(23, 137);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(64, 17);
            this.radPlayerScissors.TabIndex = 2;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Scissors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(24, 31);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 3;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(24, 75);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
            this.radComputerPaper.TabIndex = 5;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(24, 115);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(64, 17);
            this.radComputerScissors.TabIndex = 6;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Scissors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // grbPlayerGuess
            // 
            this.grbPlayerGuess.Controls.Add(this.radPlayerPaper);
            this.grbPlayerGuess.Controls.Add(this.radPlayerScissors);
            this.grbPlayerGuess.Controls.Add(this.radPlayerRock);
            this.grbPlayerGuess.Location = new System.Drawing.Point(40, 28);
            this.grbPlayerGuess.Name = "grbPlayerGuess";
            this.grbPlayerGuess.Size = new System.Drawing.Size(242, 176);
            this.grbPlayerGuess.TabIndex = 7;
            this.grbPlayerGuess.TabStop = false;
            this.grbPlayerGuess.Text = "Player Guess";
            // 
            // grbComputerGuess
            // 
            this.grbComputerGuess.Controls.Add(this.radComputerRock);
            this.grbComputerGuess.Controls.Add(this.radComputerPaper);
            this.grbComputerGuess.Controls.Add(this.radComputerScissors);
            this.grbComputerGuess.Location = new System.Drawing.Point(40, 265);
            this.grbComputerGuess.Name = "grbComputerGuess";
            this.grbComputerGuess.Size = new System.Drawing.Size(242, 194);
            this.grbComputerGuess.TabIndex = 3;
            this.grbComputerGuess.TabStop = false;
            this.grbComputerGuess.Text = "Computer Guess";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(42, 484);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(309, 225);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(35, 13);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "label1";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 519);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputerGuess);
            this.Controls.Add(this.grbPlayerGuess);
            this.Name = "frmRockPaperScissors";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.grbPlayerGuess.ResumeLayout(false);
            this.grbPlayerGuess.PerformLayout();
            this.grbComputerGuess.ResumeLayout(false);
            this.grbComputerGuess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.GroupBox grbPlayerGuess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbComputerGuess;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWinner;
    }
}

