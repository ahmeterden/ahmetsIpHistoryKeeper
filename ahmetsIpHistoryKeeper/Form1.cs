using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahmetsIpHistoryKeeper
{
    public partial class Form1 : Form
    {
        string myCurrentPublicIp = "";
        string myCurrentPrivateIp = "";
        System.Windows.Forms.NotifyIcon systemTrayIcon;


        public Form1()
        {
            InitializeComponent();
        }

        private async void getPublicIp()
        {
            TB_appLogs.Text += "@" + DateTime.Now.ToString() + " trying to get public ip...";
            toolStripStatusLabel1.Text = "Trying to get public ip...";

            try
            {
                System.Net.WebRequest req = System.Net.WebRequest.Create("http://checkip.dyndns.org");
                System.Net.WebResponse resp = await req.GetResponseAsync();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string result = sr.ReadToEnd().Trim().Split(':')[1].Substring(1).Split('<')[0];

                if (myCurrentPublicIp != result) //değişim olmuşsa
                {
                    TB_ipHistory.Text += "Public ip\t" + "@" + DateTime.Now.ToString() + "\t";
                    TB_ipHistory.Text += result + System.Environment.NewLine;
                    myCurrentPublicIp = result;
                    TB_appLogs.Text += "got! There was change." + System.Environment.NewLine;
                }
                else
                {
                    TB_appLogs.Text += "got! There were no changes." + System.Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                TB_appLogs.Text += "OOPS! There was this error:" + e.Message + System.Environment.NewLine;
            }
            finally
            {
                toolStripStatusLabel1.Text = "Ready (Click to run timer action manually)";
            }
        }

        private void getPrivateIp()
        {

            TB_appLogs.Text += "@" + DateTime.Now.ToString() + " trying to get private ip...";
            toolStripStatusLabel1.Text = "Trying to get private ip...";

            try
            {
                UdpClient u = new UdpClient("example.com", 1);
                IPAddress privateAddr = ((IPEndPoint)u.Client.LocalEndPoint).Address;

                if (myCurrentPrivateIp != privateAddr.ToString())
                {
                    TB_ipHistory.Text += "Private ip\t" + "@" + DateTime.Now.ToString() + "\t";
                    TB_ipHistory.Text += privateAddr.ToString() + System.Environment.NewLine;
                    myCurrentPrivateIp = privateAddr.ToString();
                    TB_appLogs.Text += "got! There was change." + System.Environment.NewLine;
                }
                else
                {
                    TB_appLogs.Text += "got! There were no changes." + System.Environment.NewLine;
                }
            }
            catch(Exception e)
            {
                TB_appLogs.Text += "OOPS! There was this error:" + e.Message + System.Environment.NewLine;
            }
            finally
            {
                toolStripStatusLabel1.Text = "Ready (Click to run timer action manually)";
            }


        }

        private void doTimerAction()
        {

            string filePath = "myIpHistory\\history_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log";

            //dosya yoksa
            if (!File.Exists(filePath))
            {
                TB_ipHistory.Text = "";
            }

            getPublicIp();
            getPrivateIp();

            //dosya yoksa oluşturur ve text Box'dakileri yazar ona
            //varsa içini boşaltır ve text Box'dakileri yazar ona
            File.WriteAllText(filePath, TB_ipHistory.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SetUpTrayIcon();

            string filePath = "myIpHistory\\history_" + DateTime.Now.ToString("yyyy_MM_dd") + ".log";

            //dosya varsa içini aktar TextBox'a
            if (File.Exists(filePath))
            {
                toolStripStatusLabel1.Text = "Bugüne ait log bulundu, okunuyor...";

                TextReader tr = new StreamReader(filePath, true);
                TB_ipHistory.Text = tr.ReadToEnd();
                tr.Close();

                if(TB_ipHistory.Text != "" && TB_ipHistory.Text.Contains("Public") && TB_ipHistory.Text.Contains("Private"))
                { 
                    myCurrentPublicIp = TB_ipHistory.Lines.Where(item => item.Contains("Public")).Last().Split('\t').Last();
                    myCurrentPrivateIp = TB_ipHistory.Lines.Where(item => item.Contains("Private")).Last().Split('\t').Last();
                }

                toolStripStatusLabel1.Text = "Ready (Click to run timer action manually)";
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();

                if (systemTrayIcon != null)
                {
                    systemTrayIcon.Visible = true;
                }
            }
            else
            {
                if (systemTrayIcon != null)
                {
                    systemTrayIcon.Visible = false;
                }
            }
        }

        //ilk form load edilirken 1 kez girer buraya
        private void SetUpTrayIcon()
        {
            systemTrayIcon = new System.Windows.Forms.NotifyIcon();
            systemTrayIcon.BalloonTipText = "Click this icon to restore.";
            systemTrayIcon.BalloonTipTitle = "Your app minimized to system tray";
            systemTrayIcon.Text = "Ahmet's IP History Keeper";

            //System.Reflection.Assembly myTempAss = System.Reflection.Assembly.GetExecutingAssembly();
            //string[] names = this.GetType().Assembly.GetManifestResourceNames();

            systemTrayIcon.Icon = new System.Drawing.Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("ahmetsIpHistoryKeeper.icon.ico"));

            systemTrayIcon.Click += new EventHandler(HandlerToMaximiseOnClick);
            systemTrayIcon.Visible = false;
        }

        private void HandlerToMaximiseOnClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            doTimerAction();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            this.WindowState = FormWindowState.Minimized;
            doTimerAction();
        }

        private void TBs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            doTimerAction();
        }
    }
}
