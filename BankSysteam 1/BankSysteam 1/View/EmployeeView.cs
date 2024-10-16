using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BankSysteam_1.View
{
    public partial class EmployeeView : Form
    {
        string connecstring = @"Data Source=LAPTOP-N9J5287V\SQLEXPRESS;Initial Catalog=BankSysteam;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        public EmployeeView()
        {
            InitializeComponent();
            LoadData(); // Gọi hàm tải dữ liệu khi form được khởi tạo
        }

        // Hàm để tải dữ liệu từ SQL lên DataGridView
        private void LoadData()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                con = new SqlConnection(connecstring);
                con.Open();
                string query = "SELECT * FROM dbo.EMPLOYEE"; // Sử dụng tên bảng đúng là EMPLOYEE
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dataGridView1.DataSource = dt; // Gán dữ liệu cho DataGridView
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message); // Hiển thị lỗi SQL cụ thể
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chung: " + ex.Message); // Hiển thị lỗi chung
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close(); // Đảm bảo kết nối luôn được đóng
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn vào ô trong DataGridView (nếu cần)
        }
    }
}
