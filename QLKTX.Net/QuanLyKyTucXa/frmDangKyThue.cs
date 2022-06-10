using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKyTucXa
{
    public partial class frmDangKyThue : Form
    {
        //String connString = @"Data Source=DESKTOP-07ODTJ3\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        String connString = @"Data Source=LAPTOP-1JTVO6QM\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmDangKyThue()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }
        public void LoadPhong()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Phong where SoNguoiHienTai < SoNguoiToiDa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbo_phong.DataSource = dt;
            cbo_phong.DisplayMember = "TenPhong";
            cbo_phong.ValueMember = "MaPhong";

            txt_giaPhong.DataBindings.Clear();
            txt_giaPhong.DataBindings.Add("Text", dt, "GiaPhong");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from SinhVien where MaSV ='" + txt_maSV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_tenSV.DataBindings.Clear();
            txt_tenSV.DataBindings.Add("Text", dt, "TenSV");

            txt_diaChi.DataBindings.Clear();
            txt_diaChi.DataBindings.Add("Text", dt, "DiaChi");

            txt_soDT.DataBindings.Clear();
            txt_soDT.DataBindings.Add("Text", dt, "SDT");

            txt_lop.DataBindings.Clear();
            txt_lop.DataBindings.Add("Text", dt, "Lop");

            txt_khoa.DataBindings.Clear();
            txt_khoa.DataBindings.Add("Text", dt, "KhoaHoc");

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void frmDangKyThue_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from DangKyThue";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_dangKy.DataSource = dt;
            LoadPhong();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void txt_maSV_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_phong_TextChanged(object sender, EventArgs e)
        {
            LoadPhong();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "Insert Into DangKyThue Values" + "(@maSV, @tenSV, @diaChi,@soDT,@lop, @khoa, @ngayDen,@ngayDi,@phong, @giaPhong,@tongTien)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);
                cmd.Parameters.AddWithValue("@tenSV", txt_tenSV.Text);
                cmd.Parameters.AddWithValue("@diaChi", txt_diaChi.Text);
                cmd.Parameters.AddWithValue("@SoDT", txt_soDT.Text);
                cmd.Parameters.AddWithValue("@lop", txt_lop.Text);
                cmd.Parameters.AddWithValue("@khoa", txt_khoa.Text);
                cmd.Parameters.AddWithValue("@ngayDen", dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ngayDi", dtp_ngayDi.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@phong", cbo_phong.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@giaPhong", txt_giaPhong.Text);
                cmd.Parameters.AddWithValue("@tongTien", txt_tongTien.Text);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                frmDangKyThue_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập lại mã khác!", "Thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete DangKyThue where MaSV = @maSV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@maSV", txt_maSV.Text);

                cmd.ExecuteNonQuery();
            }

            frmDangKyThue_Load(sender, e);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void dgv_dangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            dtp_ngayDen.Enabled = true;
            dtp_ngayDi.Enabled = true;
            if (row > -1)
            {
                txt_maSV.Text = dgv_dangKy.Rows[row].Cells[0].Value.ToString();
                txt_tenSV.Text = dgv_dangKy.Rows[row].Cells[1].Value.ToString();
                txt_diaChi.Text = dgv_dangKy.Rows[row].Cells[2].Value.ToString();
                txt_soDT.Text = dgv_dangKy.Rows[row].Cells[3].Value.ToString();
                txt_lop.Text = dgv_dangKy.Rows[row].Cells[4].Value.ToString();
                txt_khoa.Text = dgv_dangKy.Rows[row].Cells[5].Value.ToString();
                dtp_ngayDen.Text = dgv_dangKy.Rows[row].Cells[6].Value.ToString();
                dtp_ngayDi.Text = dgv_dangKy.Rows[row].Cells[7].Value.ToString();
                cbo_phong.SelectedValue = dgv_dangKy.Rows[row].Cells[8].Value.ToString();
                txt_giaPhong.Text = dgv_dangKy.Rows[row].Cells[9].Value.ToString();
                txt_tongTien.Text = dgv_dangKy.Rows[row].Cells[10].Value.ToString();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }


        private void txt_tongTien_TextChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));
            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
                txt_tongTien.Text = soTien.ToString();

            }
        }

        private void dtp_ngayDi_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));
            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month; 
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
                txt_tongTien.Text = soTien.ToString();
            }
        }

        private void dtp_ngayDen_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));
            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
                txt_tongTien.Text = soTien.ToString();

            }
        }

        private void cbo_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_giaPhong_TextChanged(object sender, EventArgs e)
        {
            DateTime ngayDen = DateTime.Parse(dtp_ngayDen.Value.ToString("yyyy-MM-dd"));
            DateTime ngayDi = DateTime.Parse(dtp_ngayDi.Value.ToString("yyyy-MM-dd"));
            if (ngayDi < ngayDen)
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
            }
            else
            {
                int thangDi = ngayDi.Month;
                int thangDen = ngayDen.Month;
                int soNam = ngayDi.Year - ngayDen.Year;
                int soTien = (thangDi - thangDen + soNam * 12) * int.Parse(txt_giaPhong.Text);
                txt_tongTien.Text = soTien.ToString();

            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_tenSV.Text = "";
            txt_maSV.Text = "";
            txt_lop.Text = "";
            txt_soDT.Text = "";
            txt_diaChi.Text = "";
            txt_khoa.Text = "";
            txt_tongTien.Text = "";
        }
    }
}
