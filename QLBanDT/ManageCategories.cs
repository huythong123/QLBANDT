using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
namespace QLBanDT
{

    public partial class ManageCategories : Form
    {

        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

        public ManageCategories()
        {
            InitializeComponent();
        }

        void populate()
        {
            try
            {
                // Khai báo và khởi tạo đối tượng SqlConnection
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Mở kết nối
                    con.Open();

                    // Câu lệnh SQL để lấy dữ liệu
                    string myquery = "SELECT * FROM LoaiSP";

                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);

                    // Tạo đối tượng SqlCommandBuilder
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    // Tạo DataSet để chứa dữ liệu
                    DataSet ds = new DataSet();

                    // Điền dữ liệu vào DataSet
                    da.Fill(ds);

                    // Gán DataSource cho DataGridView
                    DsUser.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void ManageCategories_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void unameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text) || string.IsNullOrWhiteSpace(FnameTb.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "INSERT INTO LoaiSP (LoaiID, TenLoai) VALUES (@LoaiId, @TenLoai)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoaiID", unameTb.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", FnameTb.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void DsUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = DsUser.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = DsUser.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "UPDATE LoaiSP SET LoaiId = @LoaiId,TenLoai = @TenLoai WHERE LoaiId = @LoaiId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoaiId", unameTb.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", FnameTb.Text);


                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại sản phẩm!");
                    }

                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "DELETE FROM LoaiSP WHERE LoaiId = @LoaiId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoaiId", unameTb.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại sản phẩm!");
                    }

                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            unameTb.Text = "";
            FnameTb.Text = "";
        }

        private void ManageCategories_Load_2(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homefrom home = new Homefrom();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
