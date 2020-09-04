using System;
using System.IO;
using System.Net;
using System.Text;

namespace Server
{
    class FtpClient
    {
        private string _Host;
        private string _UserName;
        private string _Password;
        FtpWebRequest ftpRequest;
        private Stream ftpStream;
        FtpWebResponse ftpResponse;
        private int bufferSize = 2048;

        public string Host
        {
            get
            {
                return _Host;
            }
            set
            {
                _Host = value;
            }
        }
        
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        
        public string[] directoryListDetailed(string directory) //working
        {
            string[] directoryList = null;
            try
            {
                if (directory == null || directory == "")
                {
                    directory = "/";
                }
                ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + "/" + directory);
                ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                string content = "";
                StreamReader sr = new StreamReader(ftpResponse.GetResponseStream());
                try
                {
                    while (sr.Peek() != -1)
                    {
                        content += sr.ReadLine() + "|"; 
                    }
                    directoryList = content.Split("|".ToCharArray());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    content = sr.ReadToEnd();
                    sr.Close();
                    ftpResponse.Close();
                }
                catch (ObjectDisposedException ex)
                {
                    sr.Close();
                    ftpResponse.Close();
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());
            }
            return directoryList;
        }

        public void downloadFile(string remoteFile, string localFile) //working
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + remoteFile);
                ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                byte[] byteBuffer = new byte[bufferSize];
                int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.ToString());
                }
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
            return;
        }

        public void uploadFile(string remoteFile, string localFile) //working
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + remoteFile);
                ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpStream = ftpRequest.GetRequestStream();
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                byte[] byteBuffer = new byte[bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.ToString());
                }
                localFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
            return;
        }

        public void deleteFile(string path)  //working
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path);
            Console.WriteLine("ftp://" + _Host + path);
            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }

        public void createDirectory(string path, string folderName) //working
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + path + "/" + folderName);
            Console.WriteLine("ftp://" + _Host + path + "/" + folderName);
            ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
            try
            {
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    Console.WriteLine("Directory exists");
                else
                    Console.WriteLine("Directory created");
            }
            ftpResponse.Close();
        }
        public void createFile(string directory, string filename) //working
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + directory + "/" + filename);
            Console.WriteLine("ftp://" + _Host + directory + "/" + filename);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }

        public void removeDirectory(string path) //working
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + _Host + "/" + path);
            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);
            ftpRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;
            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }
        public void UploadString(string text, string directory, string filename)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest ftpRequest =
                (FtpWebRequest)WebRequest.Create("ftp://" + _Host + directory + "/" + filename);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

            // Get network credentials.
            ftpRequest.Credentials = new NetworkCredential(_UserName, _Password);

            // Write the text's bytes into the request stream.
            ftpRequest.ContentLength = text.Length;
            using (Stream request_stream = ftpRequest.GetRequestStream())
            {
                byte[] bytes = Encoding.Default.GetBytes(text);
                request_stream.Write(bytes, 0, text.Length);
                request_stream.Close();
            }
        }
    }
}

