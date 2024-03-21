using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HostPortScanner
{
    public partial class fMainWindow : Form
    {
        public fMainWindow()
        {
            InitializeComponent();
        }

        TcpListener server;
        private void Bthello_Click(object sender, EventArgs e)
        {
            if(nudForm.Value > nudTo.Value)
            {
                MessageBox.Show("Invalid port range.");
                return;
            }

            lbHost.Items.Add("Start a scan ...");

            //My_Fun();

            Thread t1 = new Thread(My_Fun);
            t1.Start();

            lbHost.Items.Add("Scan Completed");
        }

        private void My_Fun()
        {
            for (int i = (int)nudForm.Value; i <= (int)nudTo.Value; i++)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Refresh();
                }));

                lbHost.Invoke(new MethodInvoker(delegate
                {
                    lHost.Text = "Currently, the port scan: " + i;
                }));

                try
                {
                    server = new TcpListener(IPAddress.Loopback, i);
                    server.Start();
                    server.Stop();
                }
                catch
                {
                    lbHost.Invoke(new MethodInvoker(delegate
                    {
                        lbHost.Items.Add("Port: " + i + "is busy");
                    }));
                }
            }
        }
        

        private void FMainWindow_Load(object sender, EventArgs e)
        {
        
        }
    }
}
