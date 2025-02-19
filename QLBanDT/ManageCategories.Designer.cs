namespace QLBanDT
{
    partial class ManageCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            FnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label2 = new Label();
            unameTb = new Guna.UI2.WinForms.Guna2TextBox();
            DsUser = new Guna.UI2.WinForms.Guna2DataGridView();
            label31 = new Label();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DsUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 94);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(903, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 28);
            label6.TabIndex = 1;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(256, 25);
            label1.Name = "label1";
            label1.Size = new Size(398, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            // 
            // FnameTb
            // 
            FnameTb.BorderRadius = 10;
            FnameTb.CustomizableEdges = customizableEdges1;
            FnameTb.DefaultText = "";
            FnameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            FnameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            FnameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            FnameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            FnameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            FnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FnameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            FnameTb.Location = new Point(172, 194);
            FnameTb.Margin = new Padding(4);
            FnameTb.Name = "FnameTb";
            FnameTb.PasswordChar = '\0';
            FnameTb.PlaceholderForeColor = Color.DeepSkyBlue;
            FnameTb.PlaceholderText = "";
            FnameTb.SelectedText = "";
            FnameTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            FnameTb.Size = new Size(181, 29);
            FnameTb.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(30, 195);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 18;
            label3.Text = "LOẠI SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(30, 157);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 17;
            label2.Text = "MÃ SẢN PHẨM";
            // 
            // unameTb
            // 
            unameTb.BorderRadius = 10;
            unameTb.CustomizableEdges = customizableEdges3;
            unameTb.DefaultText = "";
            unameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            unameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            unameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            unameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            unameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            unameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            unameTb.Location = new Point(172, 157);
            unameTb.Margin = new Padding(4);
            unameTb.Name = "unameTb";
            unameTb.PasswordChar = '\0';
            unameTb.PlaceholderForeColor = Color.DeepSkyBlue;
            unameTb.PlaceholderText = "";
            unameTb.SelectedText = "";
            unameTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            unameTb.Size = new Size(181, 29);
            unameTb.TabIndex = 16;
            // 
            // DsUser
            // 
            DsUser.AllowUserToAddRows = false;
            DsUser.AllowUserToDeleteRows = false;
            DsUser.AllowUserToResizeColumns = false;
            DsUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DsUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DsUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DsUser.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DsUser.DefaultCellStyle = dataGridViewCellStyle3;
            DsUser.GridColor = Color.FromArgb(231, 229, 255);
            DsUser.Location = new Point(377, 123);
            DsUser.Margin = new Padding(3, 2, 3, 2);
            DsUser.Name = "DsUser";
            DsUser.ReadOnly = true;
            DsUser.RowHeadersVisible = false;
            DsUser.RowHeadersWidth = 51;
            DsUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DsUser.RowTemplate.Height = 30;
            DsUser.Size = new Size(546, 344);
            DsUser.TabIndex = 48;
            DsUser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DsUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            DsUser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DsUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DsUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DsUser.ThemeStyle.BackColor = Color.White;
            DsUser.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DsUser.ThemeStyle.HeaderStyle.BackColor = Color.DeepSkyBlue;
            DsUser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DsUser.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DsUser.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DsUser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DsUser.ThemeStyle.HeaderStyle.Height = 25;
            DsUser.ThemeStyle.ReadOnly = true;
            DsUser.ThemeStyle.RowsStyle.BackColor = Color.White;
            DsUser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DsUser.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DsUser.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DsUser.ThemeStyle.RowsStyle.Height = 30;
            DsUser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DsUser.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DsUser.CellContentClick += DsUser_CellContentClick;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.DeepSkyBlue;
            label31.Location = new Point(537, 100);
            label31.Name = "label31";
            label31.Size = new Size(233, 21);
            label31.TabIndex = 49;
            label31.Text = "DANH SÁCH LOẠI SẢN PHẨM";
            // 
            // button7
            // 
            button7.BackColor = Color.Silver;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(40, 249);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(34, 25);
            button7.TabIndex = 54;
            button7.Text = "XÓA";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(183, 277);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(120, 28);
            button4.TabIndex = 53;
            button4.Text = "TRANG CHỦ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(280, 245);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(74, 26);
            button3.TabIndex = 52;
            button3.Text = "XOÁ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(201, 245);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(74, 26);
            button2.TabIndex = 51;
            button2.Text = "SỬA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(122, 245);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(74, 26);
            button1.TabIndex = 50;
            button1.Text = "THÊM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 494);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label31);
            Controls.Add(DsUser);
            Controls.Add(FnameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(unameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 100);
            Name = "ManageCategories";
            StartPosition = FormStartPosition.Manual;
            Text = "ManageCategories";
            Load += ManageCategories_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DsUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox FnameTb;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox unameTb;
        private Guna.UI2.WinForms.Guna2DataGridView DsUser;
        private Label label31;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}