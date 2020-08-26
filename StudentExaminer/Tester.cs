using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StudentExaminer
{
    public partial class Tester : Form
    {

        XmlReader xmlReader;
        string PersonName;
        string Theme;
        int NumberOfQuestions;
        int RightAnsw; //Right abswers quantity
        int position = 0;   // questions left

        string question;
        string[] answ = new string[4]; //Answers
        string right; //Right answer
        bool righting; //User's right answer

        public Tester(string TestPath, string personName, string theme)
        {
            InitializeComponent();

            PersonName = personName;
            Theme = theme;

            xmlReader = new XmlTextReader(TestPath);
            xmlReader.Read();
            labelQuestionsLeft.Text = "1";
            ReadNumbers();
            LoadQuestions();
            ShowQuestions();
        }

        private void ShowQuestions()
        {
            labelQuestion.Text = question;
            radioButtonAnswer1.Text = answ[0];
            radioButtonAnswer2.Text = answ[1];
            radioButtonAnswer3.Text = answ[2];
            radioButtonAnswer4.Text = answ[3];
            buttonNextQuestion.Enabled = false;
        }

        private void LoadQuestions()
        {
            
            position++;
            if (position > NumberOfQuestions)
                Finish();
            else
            {
                do xmlReader.Read();
                while (xmlReader.Name != "q" + position);

                if (xmlReader.Name == "q" + position)
                {
                    question = xmlReader.GetAttribute("text");
                    right = xmlReader.GetAttribute("right"); 
                    xmlReader.Read(); 
                    do xmlReader.Read();
                    while (xmlReader.Name != "answers");
                    xmlReader.Read(); 
                    answ = xmlReader.Value.Split('|');
                }
            }
        }

        private void Finish()
        {
            ResultsForm FF = new ResultsForm(PersonName, Theme, NumberOfQuestions, RightAnsw);
            this.Dispose();
            FF.ShowDialog();
        }

        private void ReadNumbers()
        {
            do xmlReader.Read();
            while (xmlReader.Name != "NumberOfQuestions");
            NumberOfQuestions = Convert.ToInt32(xmlReader.GetAttribute("numbers"));
            xmlReader.Read();
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            Checked();
            LoadQuestions();
            ShowQuestions();
            righting = false; 
        }

        private void Checked()
        {
            labelQuestionsLeft.Text = (position + 1).ToString();
            if (righting == true)
                RightAnsw++;
        }

        private void radioButtonAnswer_CheckedChanged(object sender, EventArgs e)
        {
            righting = false;

            if (radioButtonAnswer1.Checked)
            {
                if (radioButtonAnswer1.Text == right)
                    righting = true;
            }
            if (radioButtonAnswer2.Checked)
            {
                if (radioButtonAnswer2.Text == right)
                    righting = true;
            }
            if (radioButtonAnswer3.Checked)
            {
                if (radioButtonAnswer3.Text == right)
                    righting = true;
            }
            if (radioButtonAnswer4.Checked)
            {
                if (radioButtonAnswer4.Text == right)
                    righting = true;
            }

            buttonNextQuestion.Enabled = true;
        }
    }
}
