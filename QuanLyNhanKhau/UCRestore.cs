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

namespace QuanLyNhanKhau
{
    public partial class UCRestore : UserControl
    {
        public UCRestore()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyNhanKhau;Integrated Security=True;");


        private void UCRestore_Load(object sender, EventArgs e)
        {
            txtfile.Enabled = false;
            btnRestore.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Backup file (.bak)|*.bak";

            openFileDialog.Title = "Phục hồi dữ liệu";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string data = con.Database.ToString();

            con.Open();
            try
            {
                string sql1 = "ALTER DATABASE [" + data + "] set single_user with  rollback immediate";

                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = "use master restore DATABASE [" + data + "] from disk='"+txtfile.Text+"'with replace";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = "ALTER DATABASE [" + data + "] set multi_user";
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd2.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Khôi phục dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRestore.Enabled = false;
            }
            catch(Exception)
            {
                btnRestore.Enabled = false;
                MessageBox.Show("Khôi phục dữ liệu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
