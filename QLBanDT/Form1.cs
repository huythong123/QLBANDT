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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                guna2TextBox2.PasswordChar = '\0';
            else
                guna2TextBox2.PasswordChar = '\u25CF';
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

        private bool CheckLogin(string TaiKhoan, string MatKhau)
        {
            // Câu lệnh SQL để kiểm tra ID và mật khẩu
            string query = "SELECT COUNT(*) FROM NguoiDung WHERE Username = @Username AND Pass = @Pass";

            // Kết nối với cơ sở dữ liệu và thực thi câu lệnh SQL
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", TaiKhoan);
                cmd.Parameters.AddWithValue("@Pass", MatKhau);

                conn.Open();

                int result = (int)cmd.ExecuteScalar(); // Kiểm tra kết quả trả về từ cơ sở dữ liệu

                return result > 0; // Nếu có kết quả trả về, đăng nhập thành công
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string TaiKhoan = guna2TextBox1.Text.Trim();  // Lấy ID người dùng từ TextBox
            string MatKhau = guna2TextBox2.Text.Trim();   // Lấy Mật khẩu từ TextBox

            // Kiểm tra nếu các trường thông tin bị bỏ trống
            if (string.IsNullOrWhiteSpace(TaiKhoan) || string.IsNullOrWhiteSpace(MatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra đăng nhập
                if (CheckLogin(TaiKhoan, MatKhau))
                {
                    Homefrom home = new Homefrom();
                    home.Show();
                    this.Hide();  // Ẩn Form đăng nhập
                }
                else
                {
                    MessageBox.Show("Sai Tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý khi có lỗi kết nối hoặc lỗi khác trong quá trình kiểm tra đăng nhập
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
