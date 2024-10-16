using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSysteam_1.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void lOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eMLYOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của EmployeeView
            EmployeeView employeeView = new EmployeeView();

            // Hiển thị form EmployeeView
            employeeView.Show(); // Sử dụng Show nếu bạn muốn mở form không phải là form chính
                                 // hoặc employeeView.ShowDialog(); nếu bạn muốn form hiện dưới dạng modal (chặn các form khác cho đến khi form này đóng)
        }

        private void bRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của BranchDetailView và truyền ID chi nhánh
            BranchView branchDetailView = new BranchView();

            // Hiển thị form BranchDetailView
            branchDetailView.Show(); // Hoặc sử dụng branchDetailView.ShowDialog(); để mở dưới dạng modal
        }

        private void cREATIACCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dESPOTINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cREATIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
