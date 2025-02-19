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
    public partial class Splash : Form
    {
        // Đặt biến connectionstring bên trong lớp Splash
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

        public Splash()
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
                    string myquery = "SELECT * FROM NguoiDung";

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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text) || string.IsNullOrWhiteSpace(FnameTb.Text) ||
                string.IsNullOrWhiteSpace(PasswordTb.Text) || string.IsNullOrWhiteSpace(PhoneTb.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "INSERT INTO NguoiDung (Username, HoTen, Pass, sdt) VALUES (@Username, @HoTen, @Pass, @sdt)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", unameTb.Text);
                    cmd.Parameters.AddWithValue("@HoTen", FnameTb.Text);
                    cmd.Parameters.AddWithValue("@Pass", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@sdt", PhoneTb.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm người dùng thành công!");
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DsUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = DsUser.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = DsUser.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = DsUser.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = DsUser.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Homefrom home = new Homefrom();
            home.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "UPDATE NguoiDung SET HoTen = @HoTen, Pass = @Pass, sdt = @sdt WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", unameTb.Text);
                    cmd.Parameters.AddWithValue("@HoTen", FnameTb.Text);
                    cmd.Parameters.AddWithValue("@Pass", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@sdt", PhoneTb.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng!");
                    }

                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(unameTb.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "DELETE FROM NguoiDung WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", unameTb.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng!");
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
            PasswordTb.Text = "";
            PhoneTb.Text = "";
        }

        private void DsUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = DsUser.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = DsUser.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = DsUser.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = DsUser.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
