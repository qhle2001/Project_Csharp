using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.model;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using project.model;
using System.Data.OleDb;

namespace project
{
    public partial class main : Form
    {
        public string typetour;
        public main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.Visible = false;
            this.emailToolStripMenuItem.Visible = false;
            this.thêmTourToolStripMenuItem.Visible = false;
            this.lbdn.Visible = true;
            loaddata();
            loaddata1();
            loadimage();
            typetour = trangChủToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }
        public static bool flaggn = true;
        public static List<tourinfo> tour = new List<tourinfo>();
        public static List<tourdetail> tourdetails = new List<tourdetail>();
        public static List<saveimage> saveimages = new List<saveimage>();
        private string path = "tourinfo.xml";
        public string id, diemden, ten, image, khoihanh, thoigian, giatien;
        public string hanhtrinh;
        public string vanchuyen;
        public string diemnoibat;
        public string ngay1;
        public string ngay2;
        public string ngay3;
        public string ngay4;
        public string ngay5;
        public string ngay6;
        private void loaddata()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable dt = new DataTable();
            dt = ds.Tables["Nametour"];
            tour = new List<tourinfo>();
            foreach (DataRow dr in dt.Rows)
            {
                id = dr["ID"].ToString();
                diemden = dr["diemden"].ToString();
                ten = dr["ten"].ToString();
                image = dr["image"].ToString();
                hanhtrinh = dr["lichtrinh"].ToString();
                khoihanh = dr["khoihanh"].ToString();
                thoigian = dr["thoigian"].ToString();
                giatien = dr["giatien"].ToString();
                tourinfo tournament = new tourinfo(id, diemden, ten, hanhtrinh, khoihanh, thoigian, giatien);
                tour.Add(tournament);
            }
        }

        private void loaddata1()
        {
            OleDbConnection myconnection;
            OleDbDataAdapter mycommand;
            //myconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\\data.xlsx'" + "; Extended Properties=\"Excel 12.0; HDR=YES;\";");
            myconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= data.xlsx; Extended Properties=\"Excel 12.0; HDR=YES;\";");
            myconnection.Open();
            mycommand = new OleDbDataAdapter("select * from [sheet1$]", myconnection);
            DataSet ds = new DataSet();
            mycommand.Fill(ds);
            myconnection.Close();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                id = dr.ItemArray[0].ToString();
                ten = dr.ItemArray[1].ToString();
                hanhtrinh = dr.ItemArray[4].ToString();
                thoigian = dr.ItemArray[5].ToString();
                khoihanh = dr.ItemArray[6].ToString();
                vanchuyen = dr.ItemArray[7].ToString();
                diemnoibat = dr.ItemArray[8].ToString();
                giatien = dr.ItemArray[10].ToString();
                ngay1 = dr.ItemArray[11].ToString();
                ngay2 = dr.ItemArray[12].ToString();
                ngay3 = dr.ItemArray[13].ToString();
                ngay4 = dr.ItemArray[14].ToString();
                ngay5 = dr.ItemArray[15].ToString();
                ngay6 = dr.ItemArray[16].ToString();
                tourdetail tourdt = new tourdetail(id, ten, hanhtrinh, thoigian, khoihanh, vanchuyen, diemnoibat, giatien, ngay1, ngay2, ngay3, ngay4, ngay5, ngay6);
                tourdetails.Add(tourdt);
            }
        }

        private void loadimage()
        {
            for(int i = 0; i <tour.Count; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    saveimage save = new saveimage(tour[i].Id, tour[i].Id + "//" + j.ToString() + ".jpg");
                    saveimages.Add(save);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Dangnhap form = new Dangnhap(this);
            form.ShowDialog();
        }

        internal void reloadform()
        {
            this.menuStrip1.Visible = true;
            this.lbdn.Visible = false;
            this.ptbdn.Visible = false;
            this.emailToolStripMenuItem.Visible = true;
            this.thêmTourToolStripMenuItem.Visible = true;
            this.liênHệToolStripMenuItem.Enabled = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = false;
            this.lbdn.Visible = true;
            this.ptbdn.Visible = true;
            this.emailToolStripMenuItem.Visible = false;
            this.thêmTourToolStripMenuItem.Visible = false;
            this.liênHệToolStripMenuItem.Enabled = true;
            flaggn = true;
            typetour = trangChủToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void saPaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = saPaToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void quảngNinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = quảngNinhToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void sơnLaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = sơnLaToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void đàNẵngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = đàNẵngToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void quảngNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = quảngNamToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void khánhHòaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = khánhHòaToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void lâmĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = lâmĐồngToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void cầnThơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = cầnThơToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void kiênGiangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = kiênGiangToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void đồngNaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = đồngNaiToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void thênTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themtour uc = new Themtour();
            addUserControl(uc);
        }

        private void xóaTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xoatour uc = new Xoatour(this);
            addUserControl(uc);
        }

        public string textfind;
        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textfind = txtB.Text;
                txtB.SelectAll();
                userfind uc = new userfind(this);
                addUserControl(uc);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textfind = txtB.Text;
            txtB.SelectAll();
            userfind uc = new userfind(this);
            addUserControl(uc);
        }

        internal void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //panelContainer.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void đăngBàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themtour uc = new Themtour();
            addUserControl(uc);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            typetour = trangChủToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lienhe uc = new lienhe();
            addUserControl(uc);
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email form = new email();
            form.ShowDialog();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lbdn.Visible == true)
            {
                client form = new client();
                form.Show();
            }
            else
            {
                admin form = new admin();
                form.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đoimk form = new Đoimk();
            form.ShowDialog();
        }

        internal void reload()
        {
            flaggn = false;
            typetour = trangChủToolStripMenuItem.Text;
            home uc = new home(this);
            addUserControl(uc);
        }
    }
}
