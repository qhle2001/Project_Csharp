using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing.Text;
using System.Globalization;
using static project.main;
using project.model;

namespace project
{
    public partial class Detail : Form
    {
        home userin;
        userfind userfindin;
        bool flaguser = true;
        public string idtour;
        public string ten;
        public string hanhtrinh;
        public string thoigian;
        public string khoihanh;
        public string vanchuyen;
        public string diemnoibat;
        public string giatien;
        public string ngay1;
        public string ngay2;
        public string ngay3;
        public string ngay4;
        public string ngay5;
        public string ngay6;

        
        public Detail(userfind userin)
        {
            InitializeComponent();
            flaguser = false;
            this.WindowState = FormWindowState.Maximized;
            this.userfindin = userin;
            loadform();
            loadfpn();
            loadptb();
        }
        public Detail(home userin)
        {
            InitializeComponent();
            flaguser = true;
            this.WindowState = FormWindowState.Maximized;
            this.userin = userin;
            loadform();
            loadfpn();
            loadptb();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string idtourbuy;

        private void loadform()
        {
            if (flaguser)
            {
                idtour = userin.idmode;
                for (int i = 0; i < tourdetails.Count; i++)
                {
                    if (tourdetails[i].Idtour == userin.idmode)
                    {
                        ten = tourdetails[i].Ten;
                        hanhtrinh = tourdetails[i].Hanhtrinh;
                        thoigian = tourdetails[i].Thoigian;
                        khoihanh = tourdetails[i].Khoihanh;
                        vanchuyen = tourdetails[i].Vanchuyen;
                        diemnoibat = tourdetails[i].Diemnoibat;
                        giatien = tourdetails[i].Giatien;
                        ngay1 = tourdetails[i].Ngay1;
                        ngay2 = tourdetails[i].Ngay2;
                        ngay3 = tourdetails[i].Ngay3;
                        ngay4 = tourdetails[i].Ngay4;
                        ngay5 = tourdetails[i].Ngay5;
                        ngay6 = tourdetails[i].Ngay6;
                    }
                }
            }
            else
            {
                idtour = userfindin.idxmode;
                for (int i = 0; i < tourdetails.Count; i++)
                {
                    if (tourdetails[i].Idtour == userfindin.idxmode)
                    {
                        ten = tourdetails[i].Ten;
                        hanhtrinh = tourdetails[i].Hanhtrinh;
                        thoigian = tourdetails[i].Thoigian;
                        khoihanh = tourdetails[i].Khoihanh;
                        vanchuyen = tourdetails[i].Vanchuyen;
                        diemnoibat = tourdetails[i].Diemnoibat;
                        giatien = tourdetails[i].Giatien;
                        ngay1 = tourdetails[i].Ngay1;
                        ngay2 = tourdetails[i].Ngay2;
                        ngay3 = tourdetails[i].Ngay3;
                        ngay4 = tourdetails[i].Ngay4;
                        ngay5 = tourdetails[i].Ngay5;
                        ngay6 = tourdetails[i].Ngay6;
                    }
                }
            }
        }
        private void loadfpn()
        {
            Label lb = new Label();
            lb.Tag = "Hình ảnh";
            lb.Text = "Hình ảnh";
            lb.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Location = new Point(100, 5);
            lb.Click += new EventHandler(lbl_click);

            Label lbl = new Label();
            lbl.Tag = "Điểm nổi bật";
            lbl.Text = "Điểm nổi bật";
            lbl.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(300, 5);
            lbl.Click += new EventHandler(lbl_click);

            Label lbl1 = new Label();
            lbl1.Tag = "Hành trình";
            lbl1.Text = "Hành trình";
            lbl1.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lbl1.AutoSize = true;
            lbl1.Location = new Point(500, 5);
            lbl1.Click += new EventHandler(lbl_click);

            Label lbl2 = new Label();
            lbl2.Tag = "Thời gian";
            lbl2.Text = "Thời gian";
            lbl2.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lbl2.AutoSize = true;
            lbl2.Location = new Point(700, 5);
            lbl2.Click += new EventHandler(lbl_click);

            Label lbl3 = new Label();
            lbl3.Tag = "Vận chuyển";
            lbl3.Text = "Vận chuyển";
            lbl3.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lbl3.AutoSize = true;
            lbl3.Location = new Point(900, 5);
            lbl3.Click += new EventHandler(lbl_click);

            Label lbl4 = new Label();
            lbl4.Tag = "Lịch trình";
            lbl4.Text = "Lịch trình";
            lbl4.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lbl4.AutoSize = true;
            lbl4.Location = new Point(1100, 5);
            lbl4.Click += new EventHandler(lbl_click);

            Panel pn = new Panel();
            pn.Size = new Size(1510, 40);
            pn.BackColor = Color.AliceBlue;
            pn.Controls.Add(lb);
            pn.Controls.Add(lbl);
            pn.Controls.Add(lbl1);
            pn.Controls.Add(lbl2);
            pn.Controls.Add(lbl3);
            pn.Controls.Add(lbl4);
            fpn.Controls.Add(pn);
        }

        private void loadptb()
        {
            #region panel1;
            FlowLayoutPanel fpn1 = new FlowLayoutPanel();
            fpn1.Size = new Size(900, 500);
            fpn1.AutoScroll = true;
            fpn1.Location = new Point(10, 10);
            for (int j = 0; j < saveimages.Count; j++)
            {
                if (saveimages[j].Id == idtour)
                {
                    PictureBox ptb = new PictureBox();
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.Size = new Size(870, 490);
                    ptb.Image = new Bitmap(saveimages[j].Image);
                    fpn1.Controls.Add(ptb);
                }
            }

            Panel pn1 = new Panel();
            pn1.BorderStyle = BorderStyle.Fixed3D;
            pn1.Location = new Point(950, 10);
            pn1.Size = new Size(500, 500);

            Label lb = new Label();
            lb.Text = ten;
            lb.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lb.AutoEllipsis = true;
            lb.AutoSize = false;
            lb.Size = new Size(500, 60);
            lb.Location = new Point(0, 20);

            Label lbl = new Label();
            lbl.Text = "Thời gian: " + thoigian + "\n\nKhởi hành từ Thành phố Hồ Chí Mình vào " + khoihanh + "\n\nHành trình: " + hanhtrinh + "\n\nVận chuyển: " + vanchuyen + "\n\nGiá tiền: " + giatien;
            lbl.Font = new Font("Times New Roman", 16, FontStyle.Regular);
            lbl.AutoEllipsis = true;
            lbl.AutoSize = false;
            lbl.Size = new Size(500, 300);
            lbl.Location = new Point(0, 110);

            Button btn = new Button();
            btn.Tag = idtour;
            if (flaggn == true)
            {
                btn.Text = "Đặt tour ngay";
            }
            else
            {
                btn.Text = "Xóa tour";
            }
            btn.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            btn.Size = new Size(266, 52);
            btn.BackColor = Color.Red;
            btn.Location = new Point(125, 420);
            btn.Click += new EventHandler(btn_click);


            pn1.Controls.Add(lb);
            pn1.Controls.Add(lbl);
            pn1.Controls.Add(btn);

            Panel pn = new Panel();
            pn.Size = new Size(1510, 520);
            pn.BackColor = Color.AliceBlue;
            pn.Controls.Add(fpn1);
            pn.Controls.Add(pn1);
            #endregion;
            Panel pn_1 = new Panel();
            pn_1.Size = new Size(1510, 300);
            pn_1.BackColor = Color.AliceBlue;

            Label lb_ = new Label();
            lb_.Text = "Điểm nổi bật";
            lb_.Font = new Font("Times New Roman", 22, FontStyle.Bold);
            lb_.AutoSize = true;
            lb_.Location = new Point(10, 10);

            Label lb_1 = new Label();
            lb_1.Text = diemnoibat;
            lb_1.Font = new Font("Times New Roman", 18, FontStyle.Regular);
            lb_1.AutoEllipsis = true;
            lb_1.AutoSize = false;
            lb_1.Size = new Size(1300, 250);
            lb_1.Location = new Point(10, 60);

            pn_1.Controls.Add(lb_);
            pn_1.Controls.Add(lb_1);

            Panel pn_2 = new Panel();
            pn_2.Size = new Size(1510, 1000);
            pn_2.BackColor = Color.AliceBlue;

            Label lb_2 = new Label();
            lb_2.Text = "Lịch trình tour";
            lb_2.Font = new Font("Times New Roman", 22, FontStyle.Bold);
            lb_2.AutoSize = true;
            lb_2.Location = new Point(10, 10);


            RichTextBox rich = new RichTextBox();
            rich.Font = new Font("Times New Roman", 18, FontStyle.Regular);
            rich.Text = "Ngày 1:\n" + ngay1 + "\nNgày 2:\n" + ngay2 + "\nNgày 3:\n" + ngay3 + "\nNgày 4:\n" + ngay4 + "\nNgày 5:\n" + ngay5 + "\nNgày 6:\n" + ngay6;
            rich.Size = new Size(1490, 950);
            rich.Location = new Point(10, 60);

            pn_2.Controls.Add(lb_2);
            pn_2.Controls.Add(rich);

            fpn.Controls.Add(pn);
            fpn.Controls.Add(pn_1);
            fpn.Controls.Add(pn_2);
        }

        private void btn_click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == "Xóa tour")
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    if (tour[i].Id == idtour)
                    {
                        tour.RemoveAt(i);
                        i--;
                    }
                }
                userin.loadfpn();
                MessageBox.Show("Bạn đã xóa tour thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dattour form = new dattour(this);
                form.ShowDialog();
            }
        }
        public string texttour;
        private void lbl_click(object sender, EventArgs e)
        {
            //texttour = (Label)sender.Text;
            //if (texttour == ((Label)sender).Tag)
            //{
            //    Detailtour form = new Detailtour();
            //    form.ShowDialog();
            //}
        }

    }
}
