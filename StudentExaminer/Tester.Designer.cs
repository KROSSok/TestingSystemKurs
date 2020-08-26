namespace StudentExaminer
{
    partial class Tester
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
            this.components = new System.ComponentModel.Container();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonAnswer1 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer4 = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelQuestionsLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Location = new System.Drawing.Point(13, 13);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(775, 130);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "QUESTION";
            // 
            // radioButtonAnswer1
            // 
            this.radioButtonAnswer1.Location = new System.Drawing.Point(13, 147);
            this.radioButtonAnswer1.Name = "radioButtonAnswer1";
            this.radioButtonAnswer1.Size = new System.Drawing.Size(775, 88);
            this.radioButtonAnswer1.TabIndex = 1;
            this.radioButtonAnswer1.TabStop = true;
            this.radioButtonAnswer1.Text = "Answer1";
            this.radioButtonAnswer1.UseVisualStyleBackColor = true;
            this.radioButtonAnswer1.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // radioButtonAnswer2
            // 
            this.radioButtonAnswer2.Location = new System.Drawing.Point(13, 241);
            this.radioButtonAnswer2.Name = "radioButtonAnswer2";
            this.radioButtonAnswer2.Size = new System.Drawing.Size(775, 88);
            this.radioButtonAnswer2.TabIndex = 2;
            this.radioButtonAnswer2.TabStop = true;
            this.radioButtonAnswer2.Text = "Answer2";
            this.radioButtonAnswer2.UseVisualStyleBackColor = true;
            this.radioButtonAnswer2.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // radioButtonAnswer3
            // 
            this.radioButtonAnswer3.Location = new System.Drawing.Point(12, 335);
            this.radioButtonAnswer3.Name = "radioButtonAnswer3";
            this.radioButtonAnswer3.Size = new System.Drawing.Size(775, 88);
            this.radioButtonAnswer3.TabIndex = 3;
            this.radioButtonAnswer3.TabStop = true;
            this.radioButtonAnswer3.Text = "Answer3";
            this.radioButtonAnswer3.UseVisualStyleBackColor = true;
            this.radioButtonAnswer3.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // radioButtonAnswer4
            // 
            this.radioButtonAnswer4.Location = new System.Drawing.Point(13, 429);
            this.radioButtonAnswer4.Name = "radioButtonAnswer4";
            this.radioButtonAnswer4.Size = new System.Drawing.Size(775, 88);
            this.radioButtonAnswer4.TabIndex = 4;
            this.radioButtonAnswer4.TabStop = true;
            this.radioButtonAnswer4.Text = "Answer4";
            this.radioButtonAnswer4.UseVisualStyleBackColor = true;
            this.radioButtonAnswer4.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(13, 573);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(627, 573);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(159, 23);
            this.buttonNextQuestion.TabIndex = 6;
            this.buttonNextQuestion.Text = "Next question >>>";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // labelQuestionsLeft
            // 
            this.labelQuestionsLeft.AutoSize = true;
            this.labelQuestionsLeft.Location = new System.Drawing.Point(586, 578);
            this.labelQuestionsLeft.Name = "labelQuestionsLeft";
            this.labelQuestionsLeft.Size = new System.Drawing.Size(35, 13);
            this.labelQuestionsLeft.TabIndex = 8;
            this.labelQuestionsLeft.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "number of question:";
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuestionsLeft);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.radioButtonAnswer4);
            this.Controls.Add(this.radioButtonAnswer3);
            this.Controls.Add(this.radioButtonAnswer2);
            this.Controls.Add(this.radioButtonAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Tester";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonAnswer1;
        private System.Windows.Forms.RadioButton radioButtonAnswer2;
        private System.Windows.Forms.RadioButton radioButtonAnswer3;
        private System.Windows.Forms.RadioButton radioButtonAnswer4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelQuestionsLeft;
        private System.Windows.Forms.Label label1;
    }
}

