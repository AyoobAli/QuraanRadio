using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;

namespace QuraanRadio
{

    public partial class FrmMain : Form
    {
        // Move Form on mouse Down
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AXVLC.VLCPlugin2 vlcP = new AXVLC.VLCPlugin2();

        public static string URL = "http://ayoobali.com/quraan/radio.php?url=yes";
        public static string fileURL;

        public FrmMain()
        {
            InitializeComponent();
            vlcP.MediaPlayerEndReached += vlcP_MediaPlayerEndReached;
        }

        void vlcP_MediaPlayerEndReached()
        {
            GetFile();
        }



        public void GetFile()
        {
            

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URL);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            fileURL = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            if (fileURL.Substring(0, 4) == "http")
            {
                if (vlcP.playlist.items.count >= 1)
                {
                    if (vlcP.playlist.isPlaying) 
                    {
                        vlcP.playlist.stop();
                    }

                    vlcP.playlist.items.clear();
                }

                vlcP.playlist.add(fileURL);
                vlcP.playlist.play();
                vlcP.Volume = 100;
                

            }
            //if (fileURL.Substring(0, 4) != "http")
            //{
            //    GetFile();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string URLv = "http://ayoobali.com/quraan/radio.php?version=101";

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URLv);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string versionCheck = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            if (versionCheck != "Updated" && versionCheck.Substring(0, 1) == "v")
            {
                MessageBox.Show("Newer version is available: " + versionCheck + "\n\nVisit http://ayoobali.com to get the new update.");
                
            }

            GetFile();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblMin_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMain.ActiveForm.WindowState = FormWindowState.Minimized;
            }
            catch{}
            
        }

        private void LblPause_Click(object sender, EventArgs e)
        {

            vlcP.playlist.pause();
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            GetFile();
        }

        private void LblPlay_Click(object sender, EventArgs e)
        {
            vlcP.playlist.play();
        }

        private void LblDownload_Click(object sender, EventArgs e)
        {
            
            string[] spName = fileURL.Split('/');

            saveFile.Title = "Save Sura As";
            saveFile.Filter = "MP3|*.mp3";
            saveFile.FileName = spName[spName.Length - 1];
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                prgBar.Value = 0;
                prgBar.Visible = true;
                WebClient downloadFile = new WebClient();
                downloadFile.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                downloadFile.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                downloadFile.DownloadFileAsync(new Uri(fileURL), saveFile.FileName);

            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prgBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            prgBar.Visible = false;
        }

        private void LblAbout_Click(object sender, EventArgs e)
        {
            
            cMenu.Show(Cursor.Position.X,Cursor.Position.Y);

            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string URLv = "http://ayoobali.com/quraan/radio.php?version=101";

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(URLv);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string versionCheck = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            string AboutMSG = "Quraan Radio v1.0.1\nDeveloped By: AyoobAli.com\n\nMedia from Islamway.com";

            if (versionCheck != "Updated" && versionCheck.Substring(0, 1) == "v")
            {
                AboutMSG = AboutMSG + "\n\nNew version is available: " + versionCheck;
            }
            MessageBox.Show(AboutMSG);
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URL = "http://ayoobali.com/quraan/radio.php?url=yes";
            GetFile();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URL = "http://ayoobali.com/quraan/radio.php?url=yes&lang=en";
            GetFile();
        }


    }
}
