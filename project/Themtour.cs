using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.model;
using static project.main;

namespace project
{
    public partial class Themtour : UserControl
    {
        public Themtour()
        {
            InitializeComponent();
        }
        string[] filepath;
        string[] filename;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Filter = "jpg files (*.jpg)|*.jpg";
            result.Multiselect = true;
            result.Title = "Open";
            if (result.ShowDialog() == DialogResult.OK)
            {
                filepath = result.FileNames;
                filename = result.SafeFileNames;
                foreach(var item in filename)
                {
                    this.listBox1.Items.Add(item);
                }
            }
        }

        public string diemden, ten, image, khoihanh, thoigian, giatien;
        public string hanhtrinh;
        public string vanchuyen;
        public string diemnoibat;
        public string ngay1;
        public string ngay2;
        public string ngay3;
        public string ngay4;
        public string ngay5;
        public string ngay6;
        private void button2_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            long id = long.Parse(day + month + year + hour + minute + second);

            foreach (var item in filepath)
            {
                saveimage save = new saveimage(id.ToString(), item);
                saveimages.Add(save);
            }
            tourinfo tourinf = new tourinfo(id.ToString(), txtdiemden.Text, txtten.Text, txthanhtrinh.Text, txtkhoihanh.Text, txtthoigian.Text, txtgiatien.Text);
            tour.Add(tourinf);

            tourdetail tourdt = new tourdetail(id.ToString(), txtten.Text, txthanhtrinh.Text, txtthoigian.Text, txtkhoihanh.Text, txtvanchuyen.Text, txtdiemnoibat.Text, txtgiatien.Text, txtngay1.Text, txtngay2.Text, txtngay3.Text, txtngay4.Text, txtngay5.Text, txtngay6.Text);
            tourdetails.Add(tourdt);

            MessageBox.Show("Thêm tour thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Clear();
            txtten.Clear();
            txtvanchuyen.Clear();
            txtdiemden.Clear();
            txtdiemnoibat.Clear();
            txtgiatien.Clear();
            txthanhtrinh.Clear();
            txtkhoihanh.Clear();
            txtthoigian.Clear();
            txtngay1.Clear();
            txtngay2.Clear();
            txtngay3.Clear();
            txtngay4.Clear();
            txtngay5.Clear();
            txtngay6.Clear();
        }

    }
}
