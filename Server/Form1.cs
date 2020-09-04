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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Server
{
    public partial class Form1 : Form
    {
        FtpClient ftp = new FtpClient();
        private Socket serverSocket;
        XmlTextWriter testWriter;
        string serverDir = "";
        private Socket clientSocket; // We will only accept one socket.
        private byte[] buffer; //our XML in byteArray
        public Form1()
        {
            InitializeComponent();
            ftp.Host = "localhost";
            ftp.UserName = "KROSS";
            ftp.Password = "kross";
            StartServer();
        }
        private void StartServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, 3333));
                serverSocket.Listen(10);
                serverSocket.BeginAccept(AcceptCallback, null);
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
        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket = serverSocket.EndAccept(AR);
                buffer = new byte[clientSocket.ReceiveBufferSize];

                // Send a message to the newly connected client.
                var sendData = Encoding.ASCII.GetBytes("Hello");
                clientSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallback, null);
                // Listen for client data.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
                // Continue listening for clients.
                serverSocket.BeginAccept(AcceptCallback, null);
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

        public static string CleanInvalidXmlChars(string text)
        {
            string re = @"[^\x09\x0A\x0D\x20-\xD7FF\xE000-\xFFFD\x10000-x10FFFF]";
            return Regex.Replace(text, re, "");
        }

        private string parseFileNameXML(string xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlNodeList xnList = xmlDoc.SelectNodes("/test");
            string node = "";
            if (xnList != null && xnList.Count > 0)
            {
                foreach (XmlNode xn in xnList)
                {
                    node = xn["fileName"].InnerText;

                }
            }
            return node;
        }

        private string parseDirXML(string xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlNodeList xnList = xmlDoc.SelectNodes("/test");
            string node = "";
            if (xnList != null && xnList.Count > 0)
            {
                foreach (XmlNode xn in xnList)
                {
                    node = xn["Category"].InnerText;
                }
            }
            return node;
        }

        private void Create_Directory(string fileName) //working
        {
            serverDir = "";
            try
            {
                ftp.createDirectory(serverDir, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serverDir = fileName;
        }

        private void Create_File(string fileName) //working
        {
            try
            {
                ftp.createFile("/" + serverDir, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ReceiveCallback(IAsyncResult AR)
        {
            
            try
            {
                Console.WriteLine("waiting to receive...");
                // Socket exception will raise here when client closes, as this sample does not
                // demonstrate graceful disconnects for the sake of simplicity.
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                // The received data is deserialised buffer!!! - TO DO! - done.
                // Stream writer has to write XML on LOCALHOST!!! - TO DO!

                
                string write = Encoding.Default.GetString(buffer);
                string folder = parseDirXML(write);
                string fileName = parseFileNameXML(write);

                Console.WriteLine(folder + "....." + fileName);

                Create_Directory(folder);
                Create_File(fileName);
                ftp.UploadString(CleanInvalidXmlChars(write), "/" + serverDir, fileName);

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

        private void CreateDatabaseObject(string data)
        {

        }

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
