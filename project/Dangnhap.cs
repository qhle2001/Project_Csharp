using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Dangnhap : Form
    {
        main formout;
        public Dangnhap(main formin)
        {
            InitializeComponent();
            this.formout = formin;
            this.StartPosition = FormStartPosition.CenterScreen;
            loaddata();
        }
        private string path = "user.xml";
        public string username;
        public string pass;
        private void loaddata()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable dt = new DataTable();
            dt = ds.Tables["Username"];
            foreach(DataRow dr in dt.Rows)
            {
                username = dr["User"].ToString();
                pass = dr["Pass"].ToString();
            }
        }
        private void btndn_Click(object sender, EventArgs e)
        {
            if(txtus.Text == username && txtpass.Text == pass)
            {
                formout.reloadform();
                formout.reload();
                this.Hide();
            }
            else if(txtus.Text != username && !string.IsNullOrEmpty(txtus.Text))
            {
                MessageBox.Show("Tên đăng nhập sai!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtus.SelectAll();
                txtpass.Text = "";
                txtus.Focus();
            }
            else if(txtpass.Text != pass && !string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Sai mật khẩu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Text = "";
                txtpass.Focus();
            }
        }

        private void txtus_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtus.Text == username && txtpass.Text == pass)
                {
                    formout.reloadform();
                    formout.reload();
                    this.Hide();
                }
                else if (txtus.Text != username)
                {
                    MessageBox.Show("Tên đăng nhập sai!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtus.SelectAll();
                    txtpass.Text = "";
                    txtus.Focus();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Text = "";
                    txtpass.Focus();
                }
            }
        }

        private void btnquen_Click(object sender, EventArgs e)
        {
            Quenmk form = new Quenmk();
            form.ShowDialog();
        }
    }
}
