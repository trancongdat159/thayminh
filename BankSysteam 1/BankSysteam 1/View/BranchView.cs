using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSysteam_1.View
{
    public partial class BranchView : Form
    {
        string connecstring = @"Data Source=LAPTOP-N9J5287V\SQLEXPRESS;Initial Catalog=BankSysteam;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        public BranchView()
        {
            InitializeComponent();
            LoadBranchData(); // Tải dữ liệu chi nhánh khi khởi tạo form
        }

        // Hàm để tải dữ liệu từ bảng BRANCH
        private void LoadBranchData()
        {
            try
            {
                con = new SqlConnection(connecstring);
                con.Open();
                string query = "SELECT * FROM dbo.BRANCH"; // Truy vấn dữ liệu từ bảng BRANCH
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt; // Gán dữ liệu cho DataGridView

                // Tự động điều chỉnh kích thước cột để lấp đầy khung DataGridView
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chung: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close(); // Đảm bảo kết nối luôn được đóng
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic xử lý tại đây nếu cần
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi nhấp vào ô trong DataGridView (nếu cần)
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

 
        }
        }
}
