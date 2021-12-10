using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace PCHealth2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            logoAnimTimer.Start();
            stoutlabel.Parent = logoPictureBox;
            Clspng.Parent = logoPictureBox;
            rstpng.Parent = logoPictureBox;
        }
        
        private void logoAnimTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.2;
            if(this.Opacity == 1.0)
            {             
                logoAnimTimer.Stop();
                connectionTest();
            }
        }

        public void connectionTest()
        {
            Thread.Sleep(1000);

            try
            {
                Ping ping = new Ping();
                PingReply pingReply = ping.Send("subjectstudio.online");
                if (Convert.ToString(pingReply.Status) == "Success")
                {
                    stoutlabel.Text = "The connection is established";
                    Thread.Sleep(1000);
                    LoginForm login = new LoginForm();
                    login.Owner = login;
                    login.Show();
                    //this.Close();
                    if (this.Opacity == 0)
                    {
                        this.Opacity -= 0.2;
                    }
                    this.Opacity = 0;

                }
                
            }
            catch (Exception)
            {
                stoutlabel.Text = "No connection to the server (×_×)";
                Clspng.Visible = true;
                rstpng.Visible = true;
            }
                                     
        }

        private void Clspng_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rstpng_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Close();
        }
    }
}
