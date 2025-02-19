using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace QLBanDT
{
    public partial class Products : Form
    {
        // Chuỗi kết nối tới cơ sở dữ liệu
        private string connectionstring = "Server=DESKTOP-DCQM5O9\\SQLEXPRESS;Database=QLBanDT;Trusted_Connection=True;TrustServerCertificate=True;";

        public Products()
        {
            InitializeComponent();
        }

        // Phương thức điền danh mục sản phẩm vào ComboBox
        void FillCategories()
        {
            string query = "SELECT LoaiId, TenLoai FROM LoaiSP";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("LoaiId", typeof(int));
                        dt.Columns.Add("TenLoai", typeof(string));

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            dt.Load(rdr);
                        }

                        comboBox1.DataSource = dt.Copy();
                        comboBox1.ValueMember = "LoaiId";
                        comboBox1.DisplayMember = "TenLoai";
                        //code thêm thì bị lỗi
                        comboBox2.DataSource = dt.Copy();
                        comboBox2.ValueMember = "TenLoai";
                        comboBox2.DisplayMember = "TenLoai";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh mục sản phẩm: {ex.Message}", "Thông báo");
            }
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
                    string myquery = "SELECT SP.id, SP.TenSP, SP.Gia, SP.SL, SP.ram, SP.pin, SP.bonho, SP.Details, LoaiSP.TenLoai, SP.img " +
                                     "FROM SP " +
                                     "JOIN LoaiSP ON SP.LoaiId = LoaiSP.LoaiId"; // JOIN để lấy tên loại sản phẩm

                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);

                    // Tạo DataSet để chứa dữ liệu
                    DataSet ds = new DataSet();

                    // Điền dữ liệu vào DataSet
                    da.Fill(ds);
                    DsUser.DataSource = null;
                    // Gán DataSource cho DataGridView
                    DsUser.DataSource = ds.Tables[0];

                    // Kiểm tra và ẩn cột img nếu có
                    if (DsUser.Columns.Contains("img"))
                    {
                        DsUser.Columns["img"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }
        void filterbycategories()
        {
            try
            {
                if (comboBox2.SelectedValue == null || string.IsNullOrWhiteSpace(comboBox2.SelectedValue.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn một danh mục hợp lệ.", "Thông báo");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();

                    string myquery = @"
                SELECT SP.id, SP.TenSP, SP.Gia, SP.SL, SP.ram, SP.pin, SP.bonho, SP.Details, LoaiSP.TenLoai, SP.img
                FROM SP
                JOIN LoaiSP ON SP.LoaiId = LoaiSP.LoaiId
                WHERE LoaiSP.TenLoai = @TenLoai";

                    SqlCommand cmd = new SqlCommand(myquery, con);
                    cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = comboBox2.SelectedValue.ToString();


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DsUser.DataSource = null; // Xóa nguồn dữ liệu hiện tại
                    DsUser.DataSource = ds.Tables[0];

                    if (DsUser.Columns.Contains("img"))
                    {
                        DsUser.Columns["img"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc sản phẩm: {ex.Message}", "Thông báo");
            }
        }



        private void DsUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DsUser.SelectedRows.Count > 0) { 
            unameTb.Text = DsUser.SelectedRows[0].Cells[0].Value.ToString();
            Fnametb.Text = DsUser.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = DsUser.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = DsUser.SelectedRows[0].Cells[3].Value.ToString();
            guna2TextBox1.Text = DsUser.SelectedRows[0].Cells[4].Value.ToString();
            guna2TextBox2.Text = DsUser.SelectedRows[0].Cells[5].Value.ToString();
            guna2TextBox4.Text = DsUser.SelectedRows[0].Cells[6].Value.ToString();
            guna2TextBox3.Text = DsUser.SelectedRows[0].Cells[7].Value.ToString();
            comboBox1.Text = DsUser.SelectedRows[0].Cells[8].Value.ToString();
            var imgBytes = DsUser.SelectedRows[0].Cells["img"].Value;
            if (imgBytes != DBNull.Value && imgBytes != null)
            {
                // Chuyển đổi byte[] thành hình ảnh và hiển thị
                byte[] imageBytes = (byte[])imgBytes;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void Products_Load_1(object sender, EventArgs e)
        {
            // Điền danh mục vào ComboBox khi form được tải
            FillCategories();
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tính hợp lệ của dữ liệu đầu vào
                if (string.IsNullOrEmpty(unameTb.Text) || string.IsNullOrEmpty(Fnametb.Text) ||
                    string.IsNullOrEmpty(PasswordTb.Text) || string.IsNullOrEmpty(PhoneTb.Text) ||
                    string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text) ||
                    string.IsNullOrEmpty(guna2TextBox4.Text) || string.IsNullOrEmpty(guna2TextBox3.Text) ||
                    comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "INSERT INTO SP (id, TenSP, Gia, SL, ram, pin, bonho, Details, LoaiId, img) " +
                                   "VALUES (@id, @TenSP, @Gia, @SL, @ram, @pin, @bonho, @Details, @LoaiId, @img)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", unameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", Fnametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@SL", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ram", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@pin", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@bonho", guna2TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Details", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiId", comboBox1.SelectedValue);

                    // Kiểm tra và lưu ảnh
                    if (pictureBox1.Image != null)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                byte[] imgBytes = ms.ToArray();
                                cmd.Parameters.AddWithValue("@img", imgBytes);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Thông báo");
                            return;
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@img", DBNull.Value); // Nếu không có ảnh
                    }

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                    populate();  // Làm mới danh sách sản phẩm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào: đảm bảo các textbox không rỗng
                if (string.IsNullOrEmpty(unameTb.Text) || string.IsNullOrEmpty(Fnametb.Text) ||
                    string.IsNullOrEmpty(PasswordTb.Text) || string.IsNullOrEmpty(PhoneTb.Text) ||
                    string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text) ||
                    string.IsNullOrEmpty(guna2TextBox4.Text) || string.IsNullOrEmpty(guna2TextBox3.Text) ||
                    comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi cập nhật.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    string query = "UPDATE SP " +
                                   "SET TenSP = @TenSP, Gia = @Gia, SL = @SL, Details = @Details, LoaiId = @LoaiId, img = @img, " +
                                   "ram = @ram, pin = @pin, bonho = @bonho " +
                                   "WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", unameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", Fnametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gia", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@SL", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@ram", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@pin", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@bonho", guna2TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Details", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoaiId", comboBox1.SelectedValue);

                    // Xử lý ảnh
                    if (pictureBox1.Image != null)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                byte[] imgBytes = ms.ToArray();
                                cmd.Parameters.AddWithValue("@img", imgBytes);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Thông báo");
                            return;
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@img", DBNull.Value);  // Nếu không có ảnh
                    }

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã sản phẩm đã nhập.");
                    }

                    populate();  // Làm mới danh sách sản phẩm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản cần xóa.");
                return;
            }

            try
            {
                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    // Câu lệnh SQL để xóa người dùng theo số điện thoại
                    string query = "DELETE FROM SP WHERE id = @id";

                    // Tạo đối tượng SqlCommand
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Thêm tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@id", unameTb.Text);

                    // Mở kết nối
                    con.Open();

                    // Thực thi câu lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã xóa người dùng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng với tài khoản này.");
                    }

                    // Cập nhật lại danh sách người dùng
                    populate();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Kiểm tra và tải ảnh hợp lệ vào PictureBox
                        Image img = Image.FromFile(ofd.FileName);
                        pictureBox1.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể tải ảnh: {ex.Message}", "Thông báo");
                    }
                }
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            unameTb.Text = "";
            Fnametb.Text = "";
            PasswordTb.Text = "";
            PhoneTb.Text = "";
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            filterbycategories();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homefrom home = new Homefrom();
            home.Show();
            this.Hide();
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
