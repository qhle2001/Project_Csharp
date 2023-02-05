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

namespace project
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        IPEndPoint ipe;
        Socket client;
        TcpListener listener;
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            listener = new TcpListener(ipe);
            Thread thr = new Thread(() =>
            {
                while (true)
                {
                    listener.Start();
                    client = listener.AcceptSocket();
                    Thread rec = new Thread(Receive);
                    rec.IsBackground = true;
                    rec.Start(client);
                }
            });
            thr.IsBackground = true;
            thr.Start();
        }

        void Send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(txtmess.Text);
            client.Send(data);
            Addmessage("Admin: " + txtmess.Text);
            txtmess.Clear();
        }

        void Receive(Object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recev = new byte[1024];
                client.Receive(recev);
                string s = Encoding.UTF8.GetString(recev);
                Addmessage("Client: " + s);
            }
            
        }

        void Addmessage(string mess)
        {
            lsvmess.Items.Add(new ListViewItem() { Text = mess});
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            Send(client);
        }

        private void txtmess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send(client);
            }
        }
    }
}
