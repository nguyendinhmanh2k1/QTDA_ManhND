namespace QuanLyKyTucXa
{
    partial class FormDangNhap
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
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_taiKhoan = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.Location = new System.Drawing.Point(154, 116);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(176, 23);
            this.txt_matKhau.TabIndex = 11;
            this.txt_matKhau.UseSystemPasswordChar = true;
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taiKhoan.Location = new System.Drawing.Point(154, 71);
            this.txt_taiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(176, 23);
            this.txt_taiKhoan.TabIndex = 10;
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matKhau.Location = new System.Drawing.Point(46, 116);
            this.lbl_matKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(74, 17);
            this.lbl_matKhau.TabIndex = 9;
            this.lbl_matKhau.Text = "Mật khẩu";
            // 
            // lbl_taiKhoan
            // 
            this.lbl_taiKhoan.AutoSize = true;
            this.lbl_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taiKhoan.Location = new System.Drawing.Point(46, 71);
            this.lbl_taiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_taiKhoan.Name = "lbl_taiKhoan";
            this.lbl_taiKhoan.Size = new System.Drawing.Size(80, 17);
            this.lbl_taiKhoan.TabIndex = 8;
            this.lbl_taiKhoan.Text = "Tài khoản";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(123, 7);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(155, 31);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Đăng nhập";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btn_thoat.Image = global::QuanLyKyTucXa.Properties.Resources.Thoat32;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(256, 173);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(93, 45);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Image = global::QuanLyKyTucXa.Properties.Resources.DangNhap32;
            this.btn_dangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangNhap.Location = new System.Drawing.Point(28, 173);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(103, 45);
            this.btn_dangNhap.TabIndex = 12;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 240);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_taiKhoan);
            this.Controls.Add(this.lbl_matKhau);
            this.Controls.Add(this.lbl_taiKhoan);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_taiKhoan;
        private System.Windows.Forms.Label lbl_title;
    }
}

