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
    public partial class frmQuanLyTaiKhoan : Form
    {
        //String connString = @"Data Source=DESKTOP-07ODTJ3\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        String connString = @"Data Source=LAPTOP-1JTVO6QM\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn;
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        public void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from CanBo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cbo_maCB.DataSource = dt;
            cbo_maCB.DisplayMember = "MaCB";
            cbo_maCB.ValueMember = "MaCB";

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Select * from Accounts";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv_qlTaiKhoan.DataSource = dt;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            LoadData();
        }


        private void btb_lammoi_Click(object sender, EventArgs e)
        {
            txt_matKhau.Text = "";
            txt_taiKhoan.Text = "";
            cbo_maCB.SelectedValue = "";
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "Insert Into Accounts Values" + "(@taiKhoan, @matKhau, @maCB)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@taiKhoan", txt_taiKhoan.Text);
                cmd.Parameters.AddWithValue("@matKhau", txt_matKhau.Text);
                cmd.Parameters.AddWithValue("@maCB", cbo_maCB.SelectedValue.ToString());

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                frmQuanLyTaiKhoan_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập lại tên khác!", "Thông báo");
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Update Accounts Set MatKhau = @matKhau, MaCB=@maCB Where TaiKhoan=@taiKhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@taiKhoan", txt_taiKhoan.Text);
                cmd.Parameters.AddWithValue("@matKhau", txt_matKhau.Text);
                cmd.Parameters.AddWithValue("@maCB", cbo_maCB.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            frmQuanLyTaiKhoan_Load(sender, e);
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            String sql = "Delete Accounts Where TaiKhoan=@taiKhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd.Parameters.AddWithValue("@taiKhoan", txt_taiKhoan.Text);

                cmd.ExecuteNonQuery();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            frmQuanLyTaiKhoan_Load(sender, e);
        }
            catch (Exception)
            {

                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập lại tên khác!", "Thông báo");
            }
}

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void dgv_qlTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int row = e.RowIndex;
                txt_taiKhoan.Text = dgv_qlTaiKhoan.Rows[row].Cells[0].Value.ToString();
                txt_matKhau.Text = dgv_qlTaiKhoan.Rows[row].Cells[1].Value.ToString();
                cbo_maCB.SelectedValue = dgv_qlTaiKhoan.Rows[row].Cells[2].Value.ToString();

        }
    }
}
