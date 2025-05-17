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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace NhapHang
{
    public partial class frmCONGNO : Form
    {
        string connectionString = @"Server=LAPTOP-TU1LKMQE;Database=QLBH;Trusted_Connection=True;";
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        public frmCONGNO()
        {
            InitializeComponent();
        }
        private void frmCONGNO_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM CONGNO", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewCONGNO.DataSource = dt; 
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMACN.Text) || string.IsNullOrWhiteSpace(txtMADDH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Công Nợ và Mã Đơn Đặt Hàng.");
                return;
            }

            if (!double.TryParse(txtSOTIENNO.Text, out double tienNo) || !double.TryParse(txtSOTIENTRA.Text, out double tienTra))
            {
                MessageBox.Show("Số tiền nợ và số tiền trả phải là số hợp lệ.");
                return;
            }

            string maCN = txtMACN.Text;
            string maDDH = txtMADDH.Text;
            DateTime ngayNo = dtpNGAYNO.Value;
            string pttt = chkTIENMAT.Checked ? "Tiền mặt" : chkCHUYENKHOAN.Checked ? "Chuyển khoản" : "";

            string sql = "INSERT INTO CONGNO VALUES (@MACN, @MADDH, @SOTIEN_NO, @SOTIEN_TRA, @NGAY_NO, @PTTT)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MACN", maCN);
                        cmd.Parameters.AddWithValue("@MADDH", maDDH);
                        cmd.Parameters.AddWithValue("@SOTIEN_NO", tienNo);
                        cmd.Parameters.AddWithValue("@SOTIEN_TRA", tienTra);
                        cmd.Parameters.AddWithValue("@NGAY_NO", ngayNo);
                        cmd.Parameters.AddWithValue("@PTTT", pttt);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            LoadData();
                            MessageBox.Show("Thêm công nợ thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm công nợ.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm công nợ: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMACN.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            if (!double.TryParse(txtSOTIENNO.Text, out double tienNo) || !double.TryParse(txtSOTIENTRA.Text, out double tienTra))
            {
                MessageBox.Show("Số tiền nợ và số tiền trả phải là số hợp lệ.");
                return;
            }

            string maCN = txtMACN.Text;
            string maDDH = txtMADDH.Text;
            DateTime ngayNo = dtpNGAYNO.Value;
            string pttt = chkTIENMAT.Checked ? "Tiền mặt" : chkCHUYENKHOAN.Checked ? "Chuyển khoản" : "";

            string sql = "UPDATE CONGNO SET MADDH=@MADDH, SOTIEN_NO=@SOTIEN_NO, SOTIEN_TRA=@SOTIEN_TRA, NGAY_NO=@NGAY_NO, PTTT=@PTTT WHERE MACN=@MACN";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MACN", maCN);
                        cmd.Parameters.AddWithValue("@MADDH", maDDH);
                        cmd.Parameters.AddWithValue("@SOTIEN_NO", tienNo);
                        cmd.Parameters.AddWithValue("@SOTIEN_TRA", tienTra);
                        cmd.Parameters.AddWithValue("@NGAY_NO", ngayNo);
                        cmd.Parameters.AddWithValue("@PTTT", pttt);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            LoadData();
                            MessageBox.Show("Sửa công nợ thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy công nợ để sửa.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa công nợ: " + ex.Message);
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMACN.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                return;
            }

            string maCN = txtMACN.Text;
            string sql = "DELETE FROM CONGNO WHERE MACN=@MACN";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MACN", maCN);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            LoadData();
                            MessageBox.Show("Xoá công nợ thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy công nợ để xoá.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá công nợ: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maCN = txtMACN.Text.Trim();

            if (string.IsNullOrEmpty(maCN))
            {
                MessageBox.Show("Vui lòng nhập Mã công nợ để tìm kiếm.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM CONGNO WHERE MACN = @MACN";
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@MACN", maCN);
                    DataTable searchResult = new DataTable();
                    adapter.Fill(searchResult);

                    if (searchResult.Rows.Count > 0)
                    {
                        dataGridViewCONGNO.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy công nợ có mã: " + maCN);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa nội dung các ô nhập
            txtMACN.Clear();
            txtMADDH.Clear();
            txtSOTIENNO.Clear();
            txtSOTIENTRA.Clear();
            dtpNGAYNO.Value = DateTime.Now;
            chkTIENMAT.Checked = false;
            chkCHUYENKHOAN.Checked = false;

            // Tải lại toàn bộ dữ liệu
            LoadData();
        }
        //Dùng lại module 2(spGIAMSOTIEN_NO) của R2
        private void btnThanhToanThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMACN.Text) || string.IsNullOrWhiteSpace(txtMADDH.Text))
            {
                MessageBox.Show("Vui lòng chọn công nợ cần thanh toán.");
                return;
            }

            if (!decimal.TryParse(txtSOTIENTRATHEM.Text, out decimal soTienTraThem) || soTienTraThem <= 0)
            {
                MessageBox.Show("Số tiền trả thêm phải là số hợp lệ và lớn hơn 0.");
                return;
            }

            string maCN = txtMACN.Text.Trim();
            string maDDH = txtMADDH.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("spGIAMSOTIEN_NO", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.AddWithValue("@SOTIEN_TRATHEM", soTienTraThem);
                        cmd.Parameters.AddWithValue("@MACN", maCN);
                        cmd.Parameters.AddWithValue("@MADDH", maDDH);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData(); // Cập nhật lại DataGridView
                MessageBox.Show("Đã cập nhật thanh toán công nợ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán công nợ: " + ex.Message);
            }
        }
        //Dùng lại module 14 (spTHOIHANTRANO) của R2
        private void btnKiemTraHanTra_Click(object sender, EventArgs e)
        {
            string maCN = txtMACN.Text.Trim();
            string maDDH = txtMADDH.Text.Trim();

            if (string.IsNullOrEmpty(maCN) || string.IsNullOrEmpty(maDDH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã công nợ và Mã đơn đặt hàng.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("spTHOIHANTRANO", conn)) 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.AddWithValue("@MACN", maCN);
                        cmd.Parameters.AddWithValue("@MADDH", maDDH);

                        SqlParameter outputParam = new SqlParameter("@THONGBAO", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        cmd.ExecuteNonQuery();

                        string thongBao = outputParam.Value.ToString();
                        MessageBox.Show(thongBao, "Thông báo hạn trả nợ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra hạn trả nợ: " + ex.Message);
            }
        }
        //Dùng lại module 12 (sp_XoaDuLieuCu) của R2

        private void btnXoaDuLieuCu_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu cũ và công nợ đã hết nợ?",
            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaDuLieuCu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 120;
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData(); 
                MessageBox.Show("Đã xóa dữ liệu cũ và công nợ đã hết nợ thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu cũ: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMACN.Text = dataGridViewCONGNO.Rows[index].Cells["MACONGNO"].Value.ToString();
                txtMADDH.Text = dataGridViewCONGNO.Rows[index].Cells["MADDH"].Value.ToString();
                txtSOTIENNO.Text = dataGridViewCONGNO.Rows[index].Cells["SOTIEN_NO"].Value.ToString();
                txtSOTIENTRA.Text = dataGridViewCONGNO.Rows[index].Cells["SOTIEN_TRA"].Value.ToString();
                dtpNGAYNO.Value = DateTime.Parse(dataGridViewCONGNO.Rows[index].Cells["NGAY_NO"].Value.ToString());
                string pttt = dataGridViewCONGNO.Rows[index].Cells["PTTT"].Value.ToString();
                chkTIENMAT.Checked = (pttt == "Tiền mặt");
                chkCHUYENKHOAN.Checked = (pttt == "Chuyển khoản");
            }
        }
        private void frmCONGNO_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Tạm biệt, hẹn gặp lại lần sau :)", "Thông báo");
        }
    }
}
