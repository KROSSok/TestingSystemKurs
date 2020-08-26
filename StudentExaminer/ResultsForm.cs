using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminer
{
    public partial class ResultsForm : Form
    {
        double Mark;
        public ResultsForm(string PersonName, string Theme, int NumbersOfQwest, int RightAnswers)
        {
            InitializeComponent();

            labelUserName.Text = PersonName;
            labelTheme.Text = Theme;
            labelNumberOfQuestions.Text = NumbersOfQwest.ToString();
            labelAnswers.Text = RightAnswers.ToString();

            Mark = (100 / NumbersOfQwest) * RightAnswers;
            labelPoints.Text = Mark.ToString();
        }

        private void ResultsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
