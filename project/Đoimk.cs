using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    public partial class Đoimk : Form
    {
        public Đoimk()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loaddata();
        }
        private string path = "user.xml";
        public string id, pass;

        private void loaddata()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataTable dt = new DataTable();
            dt = ds.Tables["Username"];
            foreach (DataRow dr in dt.Rows)
            {
                id = dr["ID"].ToString();
                pass = dr["Pass"].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmkc.Text != pass)
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu cũ, mời bạn nhập lại.", "Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmkc.Text = "";
                txtmkm.Text = "";
                txtrmkm.Text = "";
            }
            else
            {
                if (txtrmkm.Text != txtmkm.Text)
                {
                    MessageBox.Show("Bạn đã nhập sai nhập lại không đúng mật khẩu mới.", "Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrmkm.Text = "";
                }
                else
                {
                    try
                    {
                        XDocument testxml = XDocument.Load(path);
                        XElement cusername = testxml.Descendants("Username").Where(c => c.Attribute("ID").Value.Equals("21102001")).FirstOrDefault();
                        cusername.Element("Pass").Value = txtrmkm.Text;
                        testxml.Save(path);
                        MessageBox.Show("Đổi mật khẩu thành công", "Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
    }
}
