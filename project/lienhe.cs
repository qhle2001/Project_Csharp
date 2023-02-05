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
using System.Net.Mail;

namespace project
{
    public partial class lienhe : UserControl
    {
        public lienhe()
        {
            InitializeComponent();
            txtname.Text = "Lê Quang Hùng";
            txtemail.Text = "hunglequang1230@gmail.com";
            txtpass.Text = "fapgjpvbjmgnywiu";
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = txtemail.Text;
            to = "20521363@gm.uit.edu.vn";
            pass = txtpass.Text;
            content = txtcnt.Text;

            MailAddress mailform = new MailAddress(from, "Lê Quang Hùng");
            MailAddress mailto = new MailAddress(to);
            MailMessage message = new MailMessage(from,to);
            message.Subject = "Test send email using C# - Lê Quang Hùng";
            message.Body = content;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from,pass);
            smtp.EnableSsl = true;

            try
            {
                if (string.IsNullOrEmpty(txtcnt.Text))
                {
                    MessageBox.Show("Bạn cần nhập nội dung.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    smtp.Send(message);
                    MessageBox.Show("Bạn đã gửi mail thành công.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "All files (*.*)|*.*";
            result.Multiselect = false;
            result.Title = "Open";
            if (result.ShowDialog() == DialogResult.OK)
            {
                label3.Text = result.SafeFileName;
            }
        }
    }
}
