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
    public partial class Quenmk : Form
    {
        public Quenmk()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt.Text = "20521363@gm.uit.edu.vn";
            loaddata();
        }

        private string path = "user.xml";
        public string username;
        public string password;
        private void loaddata()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable dt = new DataTable();
            dt = ds.Tables["Username"];
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["User"].ToString();
                password = dr["Pass"].ToString();
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = "hunglequang1230@gmail.com";
            to = txt.Text;
            pass = "fapgjpvbjmgnywiu";
            content = "Mật khẩu của bạn là: " + password;

            MailAddress mailform = new MailAddress(from, "Lê Quang Hùng");
            MailAddress mailto = new MailAddress(to);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Password send email using C# - Lê Quang Hùng";
            message.Body = content;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(message);
                MessageBox.Show("Bạn đã gửi mail thành công.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
