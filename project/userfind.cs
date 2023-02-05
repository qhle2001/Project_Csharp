using project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project.main;
using static project.home;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;

namespace project
{
    public partial class userfind : UserControl
    {
        main fornin;
        public userfind(main fornin)
        {
            InitializeComponent();
            this.fornin = fornin;
            loadform();
        }
        Panel pn;
        private void loadpn(tourinfo inf)
        {
            PictureBox ptb = new PictureBox();
            for (int i = 0; i < saveimages.Count; i++)
            {
                if (saveimages[i].Id == inf.Id)
                {
                    ptb.Tag = inf.Id;
                    ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb.Size = new Size(350, 235);
                    ptb.Image = new Bitmap(saveimages[i].Image);
                    ptb.Location = new Point(110, 10);
                    ptb.Click += new EventHandler(ptb_click);
                    break;
                }
            }

            Label lbl = new Label();
            lbl.Text = inf.Ten;
            lbl.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            lbl.AutoEllipsis = true;
            lbl.AutoSize = false;
            lbl.Size = new Size(900, 60);
            lbl.Location = new Point(470, 40);

            Label lbl1 = new Label();
            lbl1.Text = "Hành trình: " + inf.Lichtrinh + "\nKhởi hành: " + inf.Khoihanh + "\nThời gian: " + inf.Thoigian + "\nGiá tiền: " + inf.Giatien;
            lbl1.Font = new Font("Times New Roman", 16, FontStyle.Regular);
            lbl1.AutoEllipsis = true;
            lbl1.AutoSize = false;
            lbl1.Size = new Size(900, 140);
            lbl1.Location = new Point(470, 105);

            pn = new Panel();
            pn.Size = new Size(1500, 255);
            pn.Controls.Add(ptb);
            pn.Controls.Add(lbl);
            pn.Controls.Add(lbl1);
        }
        public string idxmode;
        private void ptb_click(object sender, EventArgs e)
        {
            for (int i = 0; i < tour.Count; i++)
            {
                if (tour[i].Id == ((PictureBox)sender).Tag)
                {
                    idxmode = tour[i].Id;
                    Detail form = new Detail(this);
                    form.ShowDialog();
                }
            }
        }

        private void loadform()
        {
            for (int i = 0; i < tour.Count; i++)
            {
                string text = tour[i].Id + " " + tour[i].Ten + " " + tour[i].Lichtrinh + " " + tour[i].Khoihanh + " " + tour[i].Diemden + " " + tour[i].Thoigian + " " + tour[i].Giatien;
                text = text.ToLower();
                string textfind = fornin.textfind.ToLower();
                bool b = text.Contains(textfind);
                if (b)
                {
                    loadpn(tour[i]);
                    fpn.Controls.Add(pn);
                }
            }
        }
    }
}
