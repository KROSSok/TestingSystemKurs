using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestCreator
{
    public partial class TestEditorForm : Form
    {
        XmlTextWriter testWriter; //to write *.xml-file with test
        private string filePath = " ";
        private Socket clientSocket;
        private byte[] buffer;
        public TestEditorForm()
        {
            InitializeComponent();
            
            DirectoryInfo TestsDir = new DirectoryInfo("Tests"); 
            if (!TestsDir.Exists)
                TestsDir.Create();
            comboBoxCategory.Items.AddRange(TestsDir.GetDirectories());
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            filePath = "Tests\\" + comboBoxCategory.Text + "\\" + textBoxTheme.Text + ".xml";
            
            if (comboBoxCategory.Text != "" && textBoxTheme.Text != "" && comboBoxAuthor.Text != "")
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        MessageBox.Show("The file is already exists, please change theme");
                        textBoxTheme.Text = "";
                        return;
                    } else 
                    testWriter = new XmlTextWriter(filePath, Encoding.ASCII);
                }
                catch (DirectoryNotFoundException)
                {
                    Directory.CreateDirectory("Tests\\" + comboBoxCategory.Text);
                    testWriter = new XmlTextWriter(filePath, Encoding.ASCII);
                }

                testWriter.Formatting = Formatting.Indented;
                testWriter.WriteStartDocument();

                testWriter.WriteStartElement("test");

                testWriter.WriteStartElement("path");
                testWriter.WriteString(filePath);
                testWriter.WriteEndElement();

                testWriter.WriteStartElement("Category"); 
                testWriter.WriteString(comboBoxCategory.Text);
                testWriter.WriteEndElement();

                testWriter.WriteStartElement("Author");
                testWriter.WriteString(comboBoxAuthor.Text); 
                testWriter.WriteEndElement();

                testWriter.WriteStartElement("Theme"); 
                testWriter.WriteString(textBoxTheme.Text);
                testWriter.WriteEndElement();

                testWriter.WriteStartElement("NumberOfQuestions"); 
                testWriter.WriteStartAttribute("numbers"); 
                testWriter.WriteString(numericNQuestions.Value.ToString());

                testWriter.WriteEndAttribute();

                for (int i = 1; i <= numericNQuestions.Value; i++)
                {
                    QuestionsForm QF = new QuestionsForm(i, testWriter);
                    QF.ShowDialog();
                }

                testWriter.WriteEndElement();
                testWriter.WriteEndElement(); 
                testWriter.WriteEndDocument();
                testWriter.Close();
                SendXML();
                MessageBox.Show("All questions are created  and sent to server");
                //Application.Exit();
            }
            else
            {
                MessageBox.Show("Fill all data");
            }
        }
        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = clientSocket.EndReceive(AR);
                if (received == 0)
                {
                    return;
                }
                string message = Encoding.ASCII.GetString(buffer);
                Invoke((Action)delegate
                {
                    Text = "Server says: " + message;
                });
                // Start receiving data again.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            // Avoid Pokemon exception handling in cases like these.
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
                buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        public void SendXML()
        {
            Connect();
            FileStream fs = File.OpenRead(filePath);
            try
            {
                // Serialize the textBoxes text before sending.
                byte[] buffer = ReadWholeArray(fs);
                clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            
        }
        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Connect()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // Connect to the specified host.
                var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3333);
                clientSocket.BeginConnect(endPoint, ConnectCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        public static byte[] ReadWholeArray(Stream stream)
        {
            byte[] data = new byte[stream.Length];

            int offset = 0;
            int remaining = data.Length;
            while (remaining > 0)
            {
                int read = stream.Read(data, offset, remaining);
                if (read <= 0)
                    throw new EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
            return data;
        }
    }
}
