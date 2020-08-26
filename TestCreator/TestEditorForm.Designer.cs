namespace TestCreator
{
    partial class TestEditorForm
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNQuestions = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericNQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(70, 12);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(189, 21);
            this.comboBoxCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of questions:";
            // 
            // numericNQuestions
            // 
            this.numericNQuestions.Location = new System.Drawing.Point(552, 40);
            this.numericNQuestions.Name = "numericNQuestions";
            this.numericNQuestions.Size = new System.Drawing.Size(104, 20);
            this.numericNQuestions.TabIndex = 5;
            this.numericNQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Theme:";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(70, 40);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(473, 20);
            this.textBoxTheme.TabIndex = 7;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(666, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(47, 48);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(313, 13);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(230, 21);
            this.comboBoxAuthor.TabIndex = 9;
            // 
            // TestEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 76);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericNQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "TestEditorForm";
            this.Text = "TestInfo";
            ((System.ComponentModel.ISupportInitialize)(this.numericNQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericNQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
    }
}

