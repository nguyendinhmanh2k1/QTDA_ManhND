namespace QuanLyKyTucXa
{
    partial class frmQuanLyTaiKhoan
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
            this.dgv_qlTaiKhoan = new System.Windows.Forms.DataGridView();
            this.taiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_maCB = new System.Windows.Forms.Label();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_taiKhoan = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cbo_maCB = new System.Windows.Forms.ComboBox();
            this.btb_lammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_qlTaiKhoan
            // 
            this.dgv_qlTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taiKhoan,
            this.matKhau,
            this.tenCB});
            this.dgv_qlTaiKhoan.Location = new System.Drawing.Point(11, 310);
            this.dgv_qlTaiKhoan.Name = "dgv_qlTaiKhoan";
            this.dgv_qlTaiKhoan.RowHeadersWidth = 51;
            this.dgv_qlTaiKhoan.RowTemplate.Height = 24;
            this.dgv_qlTaiKhoan.Size = new System.Drawing.Size(928, 266);
            this.dgv_qlTaiKhoan.TabIndex = 20;
            this.dgv_qlTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlTaiKhoan_CellContentClick);
            // 
            // taiKhoan
            // 
            this.taiKhoan.DataPropertyName = "TaiKhoan";
            this.taiKhoan.HeaderText = "Tài khoản";
            this.taiKhoan.MinimumWidth = 6;
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.Width = 300;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "MatKhau";
            this.matKhau.HeaderText = "mật khẩu";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            this.matKhau.Width = 300;
            // 
            // tenCB
            // 
            this.tenCB.DataPropertyName = "MaCB";
            this.tenCB.HeaderText = "Tên cán bộ";
            this.tenCB.MinimumWidth = 6;
            this.tenCB.Name = "tenCB";
            this.tenCB.Width = 300;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Next32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(797, 196);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 49);
            this.btn_thoat.TabIndex = 16;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QuanLyKyTucXa.Properties.Resources.Xoa16_1;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(577, 202);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 49);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QuanLyKyTucXa.Properties.Resources.Sua16_1;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(797, 80);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 49);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QuanLyKyTucXa.Properties.Resources.Them32_1;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(577, 80);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 49);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Location = new System.Drawing.Point(238, 154);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(275, 27);
            this.txt_matKhau.TabIndex = 15;
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taiKhoan.Location = new System.Drawing.Point(238, 91);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(275, 27);
            this.txt_taiKhoan.TabIndex = 14;
            // 
            // lbl_maCB
            // 
            this.lbl_maCB.AutoSize = true;
            this.lbl_maCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maCB.Location = new System.Drawing.Point(76, 222);
            this.lbl_maCB.Name = "lbl_maCB";
            this.lbl_maCB.Size = new System.Drawing.Size(68, 20);
            this.lbl_maCB.TabIndex = 13;
            this.lbl_maCB.Text = "Cán bộ";
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matKhau.Location = new System.Drawing.Point(76, 154);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(85, 20);
            this.lbl_matKhau.TabIndex = 12;
            this.lbl_matKhau.Text = "Mật khẩu";
            // 
            // lbl_taiKhoan
            // 
            this.lbl_taiKhoan.AutoSize = true;
            this.lbl_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taiKhoan.Location = new System.Drawing.Point(76, 93);
            this.lbl_taiKhoan.Name = "lbl_taiKhoan";
            this.lbl_taiKhoan.Size = new System.Drawing.Size(90, 20);
            this.lbl_taiKhoan.TabIndex = 11;
            this.lbl_taiKhoan.Text = "Tài khoản";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(460, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(288, 38);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "Quản lý tài khoản";
            // 
            // cbo_maCB
            // 
            this.cbo_maCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_maCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_maCB.FormattingEnabled = true;
            this.cbo_maCB.Location = new System.Drawing.Point(238, 214);
            this.cbo_maCB.Name = "cbo_maCB";
            this.cbo_maCB.Size = new System.Drawing.Size(275, 28);
            this.cbo_maCB.TabIndex = 21;
            // 
            // btb_lammoi
            // 
            this.btb_lammoi.Location = new System.Drawing.Point(700, 136);
            this.btb_lammoi.Name = "btb_lammoi";
            this.btb_lammoi.Size = new System.Drawing.Size(75, 59);
            this.btb_lammoi.TabIndex = 22;
            this.btb_lammoi.Text = "Làm Mới";
            this.btb_lammoi.UseVisualStyleBackColor = true;
            this.btb_lammoi.Click += new System.EventHandler(this.btb_lammoi_Click);
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(950, 586);
            this.Controls.Add(this.btb_lammoi);
            this.Controls.Add(this.dgv_qlTaiKhoan);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_taiKhoan);
            this.Controls.Add(this.lbl_maCB);
            this.Controls.Add(this.lbl_matKhau);
            this.Controls.Add(this.lbl_taiKhoan);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.cbo_maCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ký túc xá";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_qlTaiKhoan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.Label lbl_maCB;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_taiKhoan;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbo_maCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCB;
        private System.Windows.Forms.Button btb_lammoi;
    }
}