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
    public partial class frmTONGNO : Form
    {

        string connectionString = @"Server=LAPTOP-TU1LKMQE;Database=QLBH;Trusted_Connection=True;";
        DataTable dt;

        public frmTONGNO()
        {
            InitializeComponent();
        }

        private void frmTONGNO_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM TONGNO", conn);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewTONGNO.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMANCC.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhà cung cấp.");
                return;
            }

            if (!double.TryParse(txtTONGNO.Text, out double tongNo) || !double.TryParse(txtNOCU.Text, out double noCu))
            {
                MessageBox.Show("Tổng nợ và nợ cũ phải là số hợp lệ.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO TONGNO VALUES (@MANCC, @TONGNO, @NOCU)";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MANCC", txtMANCC.Text);
                    cmd.Parameters.AddWithValue("@TONGNO", tongNo);
                    cmd.Parameters.AddWithValue("@NOCU", noCu);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        LoadData();
                        MessageBox.Show("Thêm tổng nợ thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tổng nợ.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm tổng nợ: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMANCC.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            if (!double.TryParse(txtTONGNO.Text, out double tongNo) || !double.TryParse(txtNOCU.Text, out double noCu))
            {
                MessageBox.Show("Tổng nợ và nợ cũ phải là số hợp lệ.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE TONGNO SET TONGNO=@TONGNO, NOCU=@NOCU WHERE MANCC=@MANCC";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MANCC", txtMANCC.Text);
                    cmd.Parameters.AddWithValue("@TONGNO", tongNo);
                    cmd.Parameters.AddWithValue("@NOCU", noCu);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        LoadData();
                        MessageBox.Show("Sửa tổng nợ thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tổng nợ để sửa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa tổng nợ: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMANCC.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM TONGNO WHERE MANCC=@MANCC";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MANCC", txtMANCC.Text);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        LoadData();
                        MessageBox.Show("Xoá tổng nợ thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tổng nợ để xoá.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá tổng nợ: " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMANCC.Text.Trim();

            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng nhập Mã nhà cung cấp để tìm kiếm.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM TONGNO WHERE MaNCC = @MaNCC";
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaNCC", maNCC);
                    DataTable searchResult = new DataTable();
                    adapter.Fill(searchResult);

                    if (searchResult.Rows.Count > 0)
                    {
                        dataGridViewTONGNO.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp có mã: " + maNCC);
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
            txtMANCC.Clear();
            txtTONGNO.Clear();
            txtNOCU.Clear();

            // Tải lại toàn bộ dữ liệu
            LoadData();
        }
        //Dùng lại module 17 (spThongKeNoNhaCungCap) của R2
        private void btnThongKeNo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("spThongKeNoNhaCungCap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 120;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dtThongKe = new DataTable();
                        adapter.Fill(dtThongKe);

                        dataGridViewThongKe.DataSource = dtThongKe;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thống kê nợ nhà cung cấp: " + ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMANCC.Text = dataGridViewTONGNO.Rows[index].Cells["MANCC"].Value.ToString();
                txtTONGNO.Text = dataGridViewTONGNO.Rows[index].Cells["TONGNO"].Value.ToString();
                txtNOCU.Text = dataGridViewTONGNO.Rows[index].Cells["NOCU"].Value.ToString();
            }
        }

        private void frmTONGNO_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Tạm biệt, hẹn gặp lại lần sau :)", "Thông báo");
        }
    }
}
