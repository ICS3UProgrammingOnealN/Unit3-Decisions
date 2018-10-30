namespace ChocBoxOneal
{
    partial class ChocolateBoxesForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btnReward = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblAward = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(311, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter the number of boxes sold";
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber.Location = new System.Drawing.Point(375, 60);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 26);
            this.nudNumber.TabIndex = 1;
            // 
            // btnReward
            // 
            this.btnReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReward.Location = new System.Drawing.Point(316, 175);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(122, 49);
            this.btnReward.TabIndex = 2;
            this.btnReward.Text = "Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(24, 292);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 3;
            // 
            // lblAward
            // 
            this.lblAward.AutoSize = true;
            this.lblAward.Location = new System.Drawing.Point(24, 292);
            this.lblAward.Name = "lblAward";
            this.lblAward.Size = new System.Drawing.Size(35, 13);
            this.lblAward.TabIndex = 4;
            this.lblAward.Text = "label1";
            // 
            // ChocolateBoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 369);
            this.Controls.Add(this.lblAward);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lblQuestion);
            this.Name = "ChocolateBoxesForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChocolateBoxesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblAward;
    }
}

