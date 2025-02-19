using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDT
{
    public partial class ViewOrder : Form
    {
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";
        public ViewOrder()
        {
            InitializeComponent();
        }
        void populateOrder()
        {
            try
            {
                // Khai báo và khởi tạo đối tượng SqlConnection
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Mở kết nối
                    con.Open();

                    // Câu lệnh SQL để lấy dữ liệu từ bảng DatHang
                    string myquery = "SELECT MaDH, Id, TenKhachHang, NgayDatHang, LoaiId, Tongtien FROM DatHang";

                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);

                    // Tạo DataTable để chứa dữ liệu (thay vì DataSet vì chỉ cần một bảng)
                    DataTable dt = new DataTable();

                    // Điền dữ liệu vào DataTable
                    da.Fill(dt);

                    // Kiểm tra nếu có dữ liệu
                    if (dt.Rows.Count > 0)
                    {
                        ProdGv.DataSource = null; // Xóa dữ liệu cũ
                        ProdGv.DataSource = dt; // Gán dữ liệu mới

                        // Kiểm tra và ẩn cột img nếu có
                        if (ProdGv.Columns.Contains("img"))
                        {
                            ProdGv.Columns["img"].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu đơn hàng!", "Thông báo");
                        ProdGv.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }



        }
        private void ProdGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dòng nào được chọn
            if (ProdGv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xóa!", "Thông báo");
                return;
            }

            // Lấy MaDH từ dòng đang chọn
            string maDH = ProdGv.SelectedRows[0].Cells["MaDH"].Value.ToString();

            // Hỏi xác nhận người dùng trước khi xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn hàng {maDH} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();

                        // Câu lệnh SQL để xóa đơn hàng theo MaDH
                        string deleteQuery = "DELETE FROM DatHang WHERE MaDH = @MaDH";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@MaDH", maDH);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo");
                                populateOrder(); // Cập nhật danh sách đơn hàng
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy đơn hàng để xóa!", "Lỗi");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa đơn hàng: {ex.Message}", "Lỗi");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populateOrder();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
