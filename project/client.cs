using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace project
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;

        private void btnsent_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recev = new Thread(Receive);
            recev.IsBackground = true;
            recev.Start();
        }

        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(txtmess.Text);
            stream.Write(data, 0, data.Length);
            Addmessage("Client: " + txtmess.Text);
            txtmess.Clear();
        }

        void Receive(Object obj)
        {
            while (true)
            {
                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage("Admin: " + s);
            }

        }

        void Addmessage(string mess)
        {
            lsvmess.Items.Add(new ListViewItem() { Text = mess});
        }

        private void txtmess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send();
            }
        }
    }
}
