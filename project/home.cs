using project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using project.model;
using static project.main;

namespace project
{
    public partial class home : UserControl
    {
        main formin;
        private string path = "tourinfo.xml";
        public string id, diemden, ten, image, lichtrinh, khoihanh, thoigian, giatien;
        public home(main formin)
        {
            InitializeComponent();
            this.formin = formin;
            loadfpn();
        }

        private void xóaNhữngÔĐãChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        internal void loadfpn()
        {
            fpn.Controls.Clear();
            if (formin.typetour == "Trang chủ")
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    loadpn(tour[i]);
                    fpn.Controls.Add(pn);
                }
            }
            else
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    if (tour[i].Diemden == formin.typetour)
                    {
                        loadpn(tour[i]);
                        fpn.Controls.Add(pn);
                    }
                }
            }
        }



        public string idmode;
        private void ptb_click(object sender, EventArgs e)
        {
            for (int i = 0; i < tour.Count; i++)
            {
                if (tour[i].Id == ((PictureBox)sender).Tag)
                {
                    idmode = tour[i].Id;
                    Detail form = new Detail(this);
                    form.ShowDialog();
                }
            }
        }
    }
}
