namespace NhapHang
{
    partial class frmCONGNO
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
            this.lbMACN = new System.Windows.Forms.Label();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.lbMDDH = new System.Windows.Forms.Label();
            this.txtMADDH = new System.Windows.Forms.TextBox();
            this.lbSTN = new System.Windows.Forms.Label();
            this.lbSTT = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSOTIENNO = new System.Windows.Forms.TextBox();
            this.dataGridViewCONGNO = new System.Windows.Forms.DataGridView();
            this.lbQLCN = new System.Windows.Forms.Label();
            this.txtSOTIENTRA = new System.Windows.Forms.TextBox();
            this.dtpNGAYNO = new System.Windows.Forms.DateTimePicker();
            this.lbNN = new System.Windows.Forms.Label();
            this.lbPTTT = new System.Windows.Forms.Label();
            this.chkTIENMAT = new System.Windows.Forms.CheckBox();
            this.chkCHUYENKHOAN = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbSOTIENTRATHEM = new System.Windows.Forms.Label();
            this.txtSOTIENTRATHEM = new System.Windows.Forms.TextBox();
            this.btnThanhToanThem = new System.Windows.Forms.Button();
            this.btnKiemTraHanTra = new System.Windows.Forms.Button();
            this.btnXoaDuLieuCu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCONGNO)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMACN
            // 
            this.lbMACN.AutoSize = true;
            this.lbMACN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbMACN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMACN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMACN.Location = new System.Drawing.Point(30, 89);
            this.lbMACN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMACN.Name = "lbMACN";
            this.lbMACN.Size = new System.Drawing.Size(113, 25);
            this.lbMACN.TabIndex = 0;
            this.lbMACN.Text = "Mã công nợ";
            // 
            // txtMACN
            // 
            this.txtMACN.Location = new System.Drawing.Point(201, 88);
            this.txtMACN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(270, 30);
            this.txtMACN.TabIndex = 0;
            // 
            // lbMDDH
            // 
            this.lbMDDH.AutoSize = true;
            this.lbMDDH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMDDH.Location = new System.Drawing.Point(26, 144);
            this.lbMDDH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMDDH.Name = "lbMDDH";
            this.lbMDDH.Size = new System.Drawing.Size(158, 25);
            this.lbMDDH.TabIndex = 2;
            this.lbMDDH.Text = "Mã đơn đặt hàng";
            // 
            // txtMADDH
            // 
            this.txtMADDH.Location = new System.Drawing.Point(201, 144);
            this.txtMADDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMADDH.Name = "txtMADDH";
            this.txtMADDH.Size = new System.Drawing.Size(269, 30);
            this.txtMADDH.TabIndex = 1;
            // 
            // lbSTN
            // 
            this.lbSTN.AutoSize = true;
            this.lbSTN.Location = new System.Drawing.Point(27, 204);
            this.lbSTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSTN.Name = "lbSTN";
            this.lbSTN.Size = new System.Drawing.Size(92, 23);
            this.lbSTN.TabIndex = 4;
            this.lbSTN.Text = "Số tiền nợ";
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Location = new System.Drawing.Point(27, 269);
            this.lbSTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(94, 23);
            this.lbSTT.TabIndex = 5;
            this.lbSTT.Text = "Số tiền trả";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 578);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(134, 581);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 33);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(361, 583);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSOTIENNO
            // 
            this.txtSOTIENNO.Location = new System.Drawing.Point(201, 204);
            this.txtSOTIENNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSOTIENNO.Name = "txtSOTIENNO";
            this.txtSOTIENNO.Size = new System.Drawing.Size(270, 30);
            this.txtSOTIENNO.TabIndex = 2;
            // 
            // dataGridViewCONGNO
            // 
            this.dataGridViewCONGNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCONGNO.Location = new System.Drawing.Point(550, 98);
            this.dataGridViewCONGNO.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCONGNO.Name = "dataGridViewCONGNO";
            this.dataGridViewCONGNO.RowHeadersWidth = 51;
            this.dataGridViewCONGNO.RowTemplate.Height = 24;
            this.dataGridViewCONGNO.Size = new System.Drawing.Size(567, 589);
            this.dataGridViewCONGNO.TabIndex = 10;
            // 
            // lbQLCN
            // 
            this.lbQLCN.AutoSize = true;
            this.lbQLCN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLCN.Location = new System.Drawing.Point(414, 28);
            this.lbQLCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQLCN.Name = "lbQLCN";
            this.lbQLCN.Size = new System.Drawing.Size(225, 31);
            this.lbQLCN.TabIndex = 11;
            this.lbQLCN.Text = "QUẢN LÝ CÔNG NỢ";
            // 
            // txtSOTIENTRA
            // 
            this.txtSOTIENTRA.Location = new System.Drawing.Point(200, 269);
            this.txtSOTIENTRA.Name = "txtSOTIENTRA";
            this.txtSOTIENTRA.Size = new System.Drawing.Size(270, 30);
            this.txtSOTIENTRA.TabIndex = 3;
            // 
            // dtpNGAYNO
            // 
            this.dtpNGAYNO.Location = new System.Drawing.Point(200, 333);
            this.dtpNGAYNO.Name = "dtpNGAYNO";
            this.dtpNGAYNO.Size = new System.Drawing.Size(267, 30);
            this.dtpNGAYNO.TabIndex = 4;
            // 
            // lbNN
            // 
            this.lbNN.AutoSize = true;
            this.lbNN.Location = new System.Drawing.Point(27, 333);
            this.lbNN.Name = "lbNN";
            this.lbNN.Size = new System.Drawing.Size(78, 23);
            this.lbNN.TabIndex = 14;
            this.lbNN.Text = "Ngày nợ";
            // 
            // lbPTTT
            // 
            this.lbPTTT.AutoSize = true;
            this.lbPTTT.Location = new System.Drawing.Point(31, 403);
            this.lbPTTT.Name = "lbPTTT";
            this.lbPTTT.Size = new System.Drawing.Size(50, 23);
            this.lbPTTT.TabIndex = 15;
            this.lbPTTT.Text = "PTTT";
            // 
            // chkTIENMAT
            // 
            this.chkTIENMAT.AutoSize = true;
            this.chkTIENMAT.Location = new System.Drawing.Point(201, 403);
            this.chkTIENMAT.Name = "chkTIENMAT";
            this.chkTIENMAT.Size = new System.Drawing.Size(103, 27);
            this.chkTIENMAT.TabIndex = 5;
            this.chkTIENMAT.Text = "Tiền mặt";
            this.chkTIENMAT.UseVisualStyleBackColor = true;
            // 
            // chkCHUYENKHOAN
            // 
            this.chkCHUYENKHOAN.AutoSize = true;
            this.chkCHUYENKHOAN.Location = new System.Drawing.Point(201, 447);
            this.chkCHUYENKHOAN.Name = "chkCHUYENKHOAN";
            this.chkCHUYENKHOAN.Size = new System.Drawing.Size(145, 27);
            this.chkCHUYENKHOAN.TabIndex = 6;
            this.chkCHUYENKHOAN.Text = "Chuyển khoản";
            this.chkCHUYENKHOAN.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(232, 581);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 35);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(441, 582);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 35);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbSOTIENTRATHEM
            // 
            this.lbSOTIENTRATHEM.AutoSize = true;
            this.lbSOTIENTRATHEM.Location = new System.Drawing.Point(31, 504);
            this.lbSOTIENTRATHEM.Name = "lbSOTIENTRATHEM";
            this.lbSOTIENTRATHEM.Size = new System.Drawing.Size(141, 23);
            this.lbSOTIENTRATHEM.TabIndex = 18;
            this.lbSOTIENTRATHEM.Text = "Số tiền trả thêm";
            // 
            // txtSOTIENTRATHEM
            // 
            this.txtSOTIENTRATHEM.Location = new System.Drawing.Point(201, 504);
            this.txtSOTIENTRATHEM.Name = "txtSOTIENTRATHEM";
            this.txtSOTIENTRATHEM.Size = new System.Drawing.Size(266, 30);
            this.txtSOTIENTRATHEM.TabIndex = 19;
            // 
            // btnThanhToanThem
            // 
            this.btnThanhToanThem.Location = new System.Drawing.Point(17, 642);
            this.btnThanhToanThem.Name = "btnThanhToanThem";
            this.btnThanhToanThem.Size = new System.Drawing.Size(155, 35);
            this.btnThanhToanThem.TabIndex = 20;
            this.btnThanhToanThem.Text = "Thanh toán thêm";
            this.btnThanhToanThem.UseVisualStyleBackColor = true;
            this.btnThanhToanThem.Click += new System.EventHandler(this.btnThanhToanThem_Click);
            // 
            // btnKiemTraHanTra
            // 
            this.btnKiemTraHanTra.Location = new System.Drawing.Point(201, 642);
            this.btnKiemTraHanTra.Name = "btnKiemTraHanTra";
            this.btnKiemTraHanTra.Size = new System.Drawing.Size(177, 34);
            this.btnKiemTraHanTra.TabIndex = 21;
            this.btnKiemTraHanTra.Text = "Kiểm tra hạn trả nợ";
            this.btnKiemTraHanTra.UseVisualStyleBackColor = true;
            this.btnKiemTraHanTra.Click += new System.EventHandler(this.btnKiemTraHanTra_Click);
            // 
            // btnXoaDuLieuCu
            // 
            this.btnXoaDuLieuCu.Location = new System.Drawing.Point(420, 642);
            this.btnXoaDuLieuCu.Name = "btnXoaDuLieuCu";
            this.btnXoaDuLieuCu.Size = new System.Drawing.Size(103, 35);
            this.btnXoaDuLieuCu.TabIndex = 22;
            this.btnXoaDuLieuCu.Text = "Xóa DL cũ";
            this.btnXoaDuLieuCu.UseVisualStyleBackColor = true;
            this.btnXoaDuLieuCu.Click += new System.EventHandler(this.btnXoaDuLieuCu_Click);
            // 
            // frmCONGNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 700);
            this.Controls.Add(this.btnXoaDuLieuCu);
            this.Controls.Add(this.btnKiemTraHanTra);
            this.Controls.Add(this.btnThanhToanThem);
            this.Controls.Add(this.txtSOTIENTRATHEM);
            this.Controls.Add(this.lbSOTIENTRATHEM);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.chkCHUYENKHOAN);
            this.Controls.Add(this.chkTIENMAT);
            this.Controls.Add(this.lbPTTT);
            this.Controls.Add(this.lbNN);
            this.Controls.Add(this.dtpNGAYNO);
            this.Controls.Add(this.txtSOTIENTRA);
            this.Controls.Add(this.lbQLCN);
            this.Controls.Add(this.dataGridViewCONGNO);
            this.Controls.Add(this.txtSOTIENNO);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbSTT);
            this.Controls.Add(this.lbSTN);
            this.Controls.Add(this.txtMADDH);
            this.Controls.Add(this.lbMDDH);
            this.Controls.Add(this.txtMACN);
            this.Controls.Add(this.lbMACN);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCONGNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công nợ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCONGNO_FormClosing);
            this.Load += new System.EventHandler(this.frmCONGNO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCONGNO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMACN;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.Label lbMDDH;
        private System.Windows.Forms.TextBox txtMADDH;
        private System.Windows.Forms.Label lbSTN;
        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSOTIENNO;
        private System.Windows.Forms.DataGridView dataGridViewCONGNO;
        private System.Windows.Forms.Label lbQLCN;
        private System.Windows.Forms.TextBox txtSOTIENTRA;
        private System.Windows.Forms.DateTimePicker dtpNGAYNO;
        private System.Windows.Forms.Label lbNN;
        private System.Windows.Forms.Label lbPTTT;
        private System.Windows.Forms.CheckBox chkTIENMAT;
        private System.Windows.Forms.CheckBox chkCHUYENKHOAN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbSOTIENTRATHEM;
        private System.Windows.Forms.TextBox txtSOTIENTRATHEM;
        private System.Windows.Forms.Button btnThanhToanThem;
        private System.Windows.Forms.Button btnKiemTraHanTra;
        private System.Windows.Forms.Button btnXoaDuLieuCu;
    }
}

