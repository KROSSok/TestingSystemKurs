using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestCreator
{
    public partial class QuestionsForm : Form
    {
        XmlTextWriter testWriter; 
        int count; //Number of questions
        public QuestionsForm(int k, XmlTextWriter Writer)
        {
            testWriter = Writer;
            count = k;
            InitializeComponent();
            this.Text = "Edit question number: " + count;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text != "" && 
                textBoxWrongAnswer1.Text != "" && 
                textBoxWrongAnswer2.Text != "" && 
                textBoxWrongAnswer3.Text != "" && 
                textBoxRightAnswer.Text != "")
            {
                if (textBoxRightAnswer.Text != textBoxWrongAnswer1.Text || 
                    textBoxRightAnswer.Text != textBoxWrongAnswer2.Text || 
                    textBoxRightAnswer.Text != textBoxWrongAnswer3.Text)
                {
                    testWriter.WriteStartElement("q" + count);

                    testWriter.WriteStartAttribute("text"); 
                    testWriter.WriteString(textBoxQuestion.Text);
                    testWriter.WriteEndAttribute();

                    testWriter.WriteStartAttribute("right");
                    testWriter.WriteString(textBoxRightAnswer.Text);
                    testWriter.WriteEndAttribute(); 

                    testWriter.WriteStartElement("answers");
                    testWriter.WriteString(textBoxRightAnswer.Text
                        + "|" + textBoxWrongAnswer1.Text 
                        + "|" + textBoxWrongAnswer2.Text 
                        + "|" + textBoxWrongAnswer3.Text); 
                    testWriter.WriteEndElement();

                    testWriter.WriteEndElement(); 


                    this.Dispose(); 
                }
                else
                {
                    MessageBox.Show("There are more than one right question", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all data", "Error!");
            }
        }

        private void QuestionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
