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

namespace project
{
    public partial class Xoatour : UserControl
    {
        main formin;
        public Xoatour(main formin)
        {
            InitializeComponent();
            load_listview();
            this.formin = formin;  
        }

        ImageList imagelist;
        void LoadImageList()
        {
            imagelist = new ImageList() { ImageSize = new Size(68, 68), ColorDepth = ColorDepth.Depth32Bit };
            for (int i = 0; i < tour.Count; i++)
            {
                //imagelist.Images.Add(tour[i].Image);
            }
        }

        private void load_listview()
        {
            lsv.CheckBoxes = true;
            lsv.GridLines = true;
            lsv.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lsv.Columns.Add("Tên", -2, HorizontalAlignment.Left);
            lsv.Columns.Add("Điểm đến", -2, HorizontalAlignment.Left);
            lsv.Columns.Add("Lịch trình", -2, HorizontalAlignment.Left);
            lsv.Columns.Add("Khởi hành", -2, HorizontalAlignment.Left);
            lsv.Columns.Add("Thời gian", -2, HorizontalAlignment.Left);
            lsv.Columns.Add("Giá tiền", -2, HorizontalAlignment.Right);

            for (int i = 0; i < tour.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = tour[i].Id;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tour[i].Ten });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tour[i].Diemden });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tour[i].Lichtrinh });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tour[i].Khoihanh });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tour[i].Thoigian });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tour[i].Giatien });
                lsv.Items.Add(item);
            }
            lsv.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            lsv.ForeColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsv.Items.Count; i++)
            {
                if (lsv.Items[i].Checked)
                {
                    lsv.Items[i].Remove();
                    tour.RemoveAt(i);
                    i--;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Themtour uc = new Themtour();
            formin.addUserControl(uc);
        }
    }
}
