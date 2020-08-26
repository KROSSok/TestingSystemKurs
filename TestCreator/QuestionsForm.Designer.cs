namespace TestCreator
{
    partial class QuestionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelWQuestion1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRightAnswer = new System.Windows.Forms.TextBox();
            this.textBoxWrongAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxWrongAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxWrongAnswer3 = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(72, 13);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(643, 94);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // labelWQuestion1
            // 
            this.labelWQuestion1.AutoSize = true;
            this.labelWQuestion1.Location = new System.Drawing.Point(14, 122);
            this.labelWQuestion1.Name = "labelWQuestion1";
            this.labelWQuestion1.Size = new System.Drawing.Size(72, 13);
            this.labelWQuestion1.TabIndex = 2;
            this.labelWQuestion1.Text = "Right answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wrong answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wrong answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wrong answer:";
            // 
            // textBoxRightAnswer
            // 
            this.textBoxRightAnswer.Location = new System.Drawing.Point(105, 119);
            this.textBoxRightAnswer.Multiline = true;
            this.textBoxRightAnswer.Name = "textBoxRightAnswer";
            this.textBoxRightAnswer.Size = new System.Drawing.Size(610, 57);
            this.textBoxRightAnswer.TabIndex = 6;
            // 
            // textBoxWrongAnswer1
            // 
            this.textBoxWrongAnswer1.Location = new System.Drawing.Point(105, 183);
            this.textBoxWrongAnswer1.Multiline = true;
            this.textBoxWrongAnswer1.Name = "textBoxWrongAnswer1";
            this.textBoxWrongAnswer1.Size = new System.Drawing.Size(610, 57);
            this.textBoxWrongAnswer1.TabIndex = 7;
            // 
            // textBoxWrongAnswer2
            // 
            this.textBoxWrongAnswer2.Location = new System.Drawing.Point(105, 246);
            this.textBoxWrongAnswer2.Multiline = true;
            this.textBoxWrongAnswer2.Name = "textBoxWrongAnswer2";
            this.textBoxWrongAnswer2.Size = new System.Drawing.Size(610, 57);
            this.textBoxWrongAnswer2.TabIndex = 8;
            // 
            // textBoxWrongAnswer3
            // 
            this.textBoxWrongAnswer3.Location = new System.Drawing.Point(105, 309);
            this.textBoxWrongAnswer3.Multiline = true;
            this.textBoxWrongAnswer3.Name = "textBoxWrongAnswer3";
            this.textBoxWrongAnswer3.Size = new System.Drawing.Size(610, 57);
            this.textBoxWrongAnswer3.TabIndex = 9;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(311, 404);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(95, 34);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxWrongAnswer3);
            this.Controls.Add(this.textBoxWrongAnswer2);
            this.Controls.Add(this.textBoxWrongAnswer1);
            this.Controls.Add(this.textBoxRightAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWQuestion1);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label1);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelWQuestion1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRightAnswer;
        private System.Windows.Forms.TextBox textBoxWrongAnswer1;
        private System.Windows.Forms.TextBox textBoxWrongAnswer2;
        private System.Windows.Forms.TextBox textBoxWrongAnswer3;
        private System.Windows.Forms.Button buttonNext;
    }
}