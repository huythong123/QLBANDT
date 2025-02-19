namespace QLBanDT
{
    partial class ViewOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ProdGv = new Guna.UI2.WinForms.Guna2DataGridView();
            button2 = new Button();
            DELETE = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProdGv).BeginInit();
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
            panel1.Size = new Size(858, 94);
            panel1.TabIndex = 2;
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
            label1.Location = new Point(283, 26);
            label1.Name = "label1";
            label1.Size = new Size(337, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 502);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 8);
            panel2.TabIndex = 22;
            // 
            // ProdGv
            // 
            ProdGv.AllowUserToAddRows = false;
            ProdGv.AllowUserToDeleteRows = false;
            ProdGv.AllowUserToResizeColumns = false;
            ProdGv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ProdGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProdGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProdGv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProdGv.DefaultCellStyle = dataGridViewCellStyle3;
            ProdGv.GridColor = Color.FromArgb(231, 229, 255);
            ProdGv.Location = new Point(213, 109);
            ProdGv.Margin = new Padding(3, 2, 3, 2);
            ProdGv.Name = "ProdGv";
            ProdGv.ReadOnly = true;
            ProdGv.RowHeadersVisible = false;
            ProdGv.RowHeadersWidth = 51;
            ProdGv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ProdGv.RowTemplate.Height = 30;
            ProdGv.Size = new Size(479, 340);
            ProdGv.TabIndex = 50;
            ProdGv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProdGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProdGv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProdGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProdGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProdGv.ThemeStyle.BackColor = Color.White;
            ProdGv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProdGv.ThemeStyle.HeaderStyle.BackColor = Color.DeepSkyBlue;
            ProdGv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProdGv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProdGv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProdGv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProdGv.ThemeStyle.HeaderStyle.Height = 25;
            ProdGv.ThemeStyle.ReadOnly = true;
            ProdGv.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProdGv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProdGv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ProdGv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ProdGv.ThemeStyle.RowsStyle.Height = 30;
            ProdGv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProdGv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProdGv.CellContentClick += ProdGv_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(344, 454);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 51;
            button2.Text = "TRỞ LẠI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DELETE
            // 
            DELETE.BackColor = Color.DeepSkyBlue;
            DELETE.FlatAppearance.BorderSize = 0;
            DELETE.FlatStyle = FlatStyle.Flat;
            DELETE.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DELETE.ForeColor = Color.White;
            DELETE.Location = new Point(459, 454);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(145, 38);
            DELETE.TabIndex = 52;
            DELETE.Text = "XÓA ĐƠN HÀNG";
            DELETE.UseVisualStyleBackColor = false;
            DELETE.Click += DELETE_Click;
            // 
            // ViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 510);
            Controls.Add(DELETE);
            Controls.Add(button2);
            Controls.Add(ProdGv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrder";
            Load += ViewOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProdGv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView ProdGv;
        private Button button2;
        private Button DELETE;
    }
}