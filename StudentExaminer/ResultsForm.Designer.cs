namespace StudentExaminer
{
    partial class ResultsForm
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.labelNumberOfQuestions = new System.Windows.Forms.Label();
            this.labelAnswers = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(79, 12);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "label1";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(82, 42);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(35, 13);
            this.labelTheme.TabIndex = 1;
            this.labelTheme.Text = "label2";
            // 
            // labelNumberOfQuestions
            // 
            this.labelNumberOfQuestions.AutoSize = true;
            this.labelNumberOfQuestions.Location = new System.Drawing.Point(129, 74);
            this.labelNumberOfQuestions.Name = "labelNumberOfQuestions";
            this.labelNumberOfQuestions.Size = new System.Drawing.Size(35, 13);
            this.labelNumberOfQuestions.TabIndex = 2;
            this.labelNumberOfQuestions.Text = "label3";
            // 
            // labelAnswers
            // 
            this.labelAnswers.AutoSize = true;
            this.labelAnswers.Location = new System.Drawing.Point(146, 105);
            this.labelAnswers.Name = "labelAnswers";
            this.labelAnswers.Size = new System.Drawing.Size(35, 13);
            this.labelAnswers.TabIndex = 3;
            this.labelAnswers.Text = "label4";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(61, 140);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(35, 13);
            this.labelPoints.TabIndex = 4;
            this.labelPoints.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of questions:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Test theme:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Number of right answers:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Points:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(106, 170);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 205);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelAnswers);
            this.Controls.Add(this.labelNumberOfQuestions);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.labelUserName);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.Label labelNumberOfQuestions;
        private System.Windows.Forms.Label labelAnswers;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonExit;
    }
}