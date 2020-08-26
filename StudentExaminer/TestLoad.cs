using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StudentExaminer
{
    public partial class TestLoad : Form
    {
        XmlReader xmlThemeRead;
        DirectoryInfo testsDirectory = new DirectoryInfo("Tests"); //Создаем объект сообтветствующий папке Tests
        DirectoryInfo testResultDirectory = new DirectoryInfo("TestResults"); //Создаем объект сообтветствующий папке Tests
        DirectoryInfo sourceDirectory = new DirectoryInfo(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName +
                "\\TestingSystem\\TestCreator\\bin\\Debug\\Tests\\");
        public string USER_NAME;
        public string selectedTheme;

        public TestLoad(string userName)
        {
            InitializeComponent();
            USER_NAME = userName;
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Dispose();
            }

            if (testsDirectory.Exists == false)
                testsDirectory.Create();
            CopyAll(sourceDirectory, testsDirectory);
            comboBoxCategory.Items.AddRange(testsDirectory.GetDirectories());
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void listBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xmlThemeRead = new XmlTextReader("Tests\\" + comboBoxCategory.Text + "\\" + listBoxTheme.Text + ".xml");
                do xmlThemeRead.Read();
                while (xmlThemeRead.Name != "Theme");

                xmlThemeRead.Read();
                selectedTheme = listBoxTheme.SelectedItem.ToString();
                buttonStartTest.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("File doesn't exist", "Error!");
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo testsDir = new DirectoryInfo("Tests\\" + comboBoxCategory.Text);
            listBoxTheme.Items.Clear();

            foreach (FileInfo file in testsDir.GetFiles())
            {
                listBoxTheme.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }

            buttonStartTest.Enabled = false;
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            if (testResultDirectory.Exists == false)
                testResultDirectory.Create();
            
            string xmlPath = "Tests\\" + comboBoxCategory.Text + "\\" + selectedTheme + ".xml";

            Tester test = new Tester(xmlPath, USER_NAME, listBoxTheme.Text);
            
            test.Show();

            
        }
    }

}
