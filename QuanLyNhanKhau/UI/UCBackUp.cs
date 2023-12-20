using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanKhau.UI
{
    public partial class UCBackUp : UserControl
    {
        public UCBackUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyNhanKhau;Integrated Security=True;");

        private void UCBackUp_Load(object sender, EventArgs e)
        {
            txtfile.Enabled = false;
            btnBackup.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = fd.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string db = con.Database.ToString();
            if (string.IsNullOrEmpty(txtfile.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn lưu file BackUp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "BACKUP Database [" + db + "] To Disk ='" + txtfile.Text + "\\" + db + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")+".bak'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("BackUp Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBackup.Enabled = false;

            }
        }
    }
}
