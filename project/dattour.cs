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
using static project.main;

namespace project
{
    public partial class dattour : Form
    {
        Detail formin;
        public dattour(Detail formin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.formin = formin;
            loadform();
        }

        private void loadform()
        {
            txtname.Text = "Lê Quang Hùng";
            txtmail.Text = "hunglequang1230@gmail.com";
            this.txtname.Enabled = false;
            this.txtmail.Enabled = false;
            for (int i = 0; i <tour.Count; i++)
            {
                if (tour[i].Id == formin.idtour)
                {
                    lbten.Text = tour[i].Ten;
                    lbhanhtrinh.Text = tour[i].Lichtrinh;
                    lbkhoihanh.Text = "Khỏi hành từ thành phố Hồ Chí Minh vào " + tour[i].Khoihanh;
                    lbthoigian.Text = tour[i].Thoigian;
                    lbgiatien.Text = tour[i].Giatien;
                    string ngaykhoihanh = tour[i].Khoihanh.ToLower();
                    bool flag = ngaykhoihanh.Contains("thứ");
                    if (flag)
                    {
                        txbkhoihanh.Enabled = true;
                    }
                    else
                    {
                        txbkhoihanh.Enabled = false;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = txtmail.Text;
            to = "20521363@gm.uit.edu.vn";
            pass = "fapgjpvbjmgnywiu";
            if (txbkhoihanh.Enabled == false)
            {
                content = "Lê Quang Hùng đặt tour có tên: " + lbten.Text + ", Lịch trình: " + lbhanhtrinh.Text + ", Khởi hành: " + lbkhoihanh.Text + ", Thời gian: " + lbthoigian.Text + ", Giá tiền: " + lbgiatien.Text;
            }
            else
            {
                content = "Lê Quang Hùng đặt tour có tên: " + lbten.Text + ", Lịch trình: " + lbhanhtrinh.Text + ", Khởi hành: " + txbkhoihanh.Text + ", Thời gian: " + lbthoigian.Text + ", Giá tiền: " + lbgiatien.Text;
            }

            MailAddress mailform = new MailAddress(from, "Lê Quang Hùng");
            MailAddress mailto = new MailAddress(to);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Đặt tour du lịch - Lê Quang Hùng";
            message.Body = content;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.EnableSsl = true;

            try
            {
                if (txbkhoihanh.Enabled == true && string.IsNullOrEmpty(txbkhoihanh.Text))
                {
                    MessageBox.Show("Bạn cần nhập nội dung.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    smtp.Send(message);
                    MessageBox.Show("Bạn đã gửi mail thành công.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
