namespace StudentExaminer
{
    partial class TestLoad
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
            this.listBoxTheme = new System.Windows.Forms.ListBox();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(102, 6);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(241, 21);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chose theme:";
            // 
            // listBoxTheme
            // 
            this.listBoxTheme.FormattingEnabled = true;
            this.listBoxTheme.Location = new System.Drawing.Point(102, 45);
            this.listBoxTheme.Name = "listBoxTheme";
            this.listBoxTheme.Size = new System.Drawing.Size(241, 108);
            this.listBoxTheme.TabIndex = 3;
            this.listBoxTheme.SelectedIndexChanged += new System.EventHandler(this.listBoxTheme_SelectedIndexChanged);
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(127, 164);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(95, 23);
            this.buttonStartTest.TabIndex = 4;
            this.buttonStartTest.Text = "START TEST";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // TestLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 199);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.listBoxTheme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "TestLoad";
            this.Text = "TestLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTheme;
        private System.Windows.Forms.Button buttonStartTest;
    }
}