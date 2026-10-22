using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G4_QLVatLieu.UI
{
    public partial class frmHoaDonNhap : Form
    {
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenNCC;
        private TextBox txtTenNV;
        private TextBox txtSoHDN;
        private DateTimePicker dtpNgayNhap;
        private ComboBox cboNCC;
        private ComboBox cboNhanVien;
        private GroupBox gbChiTiet;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cboMaNoiThat;
        private Button btnXoaHang;
        private Button btnThemHang;
        private NumericUpDown nudSoLuong;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtDonGia;
        private TextBox txtTenNoiThat;
        private Panel pnlBottom;
        private TextBox txtTongTien;
        private Label label15;
        private Button btnDong;
        private Button btnInHD;
        private Button btnHuyHD;
        private Button btnLuuHD;
        private Button btnThemHD;
        private DataGridView dgvChiTietNhap;
        private DataGridViewTextBoxColumn colMaNT;
        private DataGridViewTextBoxColumn colTenNT;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colGiamGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private GroupBox gbThongTinChung;

        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.gbThongTinChung = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.gbChiTiet = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMaNoiThat = new System.Windows.Forms.ComboBox();
            this.txtTenNoiThat = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.btnXoaHang = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.colMaNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinChung.SuspendLayout();
            this.gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinChung
            // 
            this.gbThongTinChung.Controls.Add(this.cboNCC);
            this.gbThongTinChung.Controls.Add(this.cboNhanVien);
            this.gbThongTinChung.Controls.Add(this.dtpNgayNhap);
            this.gbThongTinChung.Controls.Add(this.txtDienThoai);
            this.gbThongTinChung.Controls.Add(this.txtDiaChi);
            this.gbThongTinChung.Controls.Add(this.txtTenNCC);
            this.gbThongTinChung.Controls.Add(this.txtTenNV);
            this.gbThongTinChung.Controls.Add(this.txtSoHDN);
            this.gbThongTinChung.Controls.Add(this.label8);
            this.gbThongTinChung.Controls.Add(this.label7);
            this.gbThongTinChung.Controls.Add(this.label6);
            this.gbThongTinChung.Controls.Add(this.label5);
            this.gbThongTinChung.Controls.Add(this.label4);
            this.gbThongTinChung.Controls.Add(this.label3);
            this.gbThongTinChung.Controls.Add(this.label2);
            this.gbThongTinChung.Controls.Add(this.label1);
            this.gbThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongTinChung.Location = new System.Drawing.Point(0, 0);
            this.gbThongTinChung.Name = "gbThongTinChung";
            this.gbThongTinChung.Size = new System.Drawing.Size(1078, 135);
            this.gbThongTinChung.TabIndex = 0;
            this.gbThongTinChung.TabStop = false;
            this.gbThongTinChung.Text = "Thông tin chung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số HDN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên NV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã NCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên NCC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(815, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "SĐT:";
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Location = new System.Drawing.Point(100, 32);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(150, 26);
            this.txtSoHDN.TabIndex = 8;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(885, 32);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(175, 26);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(370, 82);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(150, 26);
            this.txtTenNCC.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(630, 82);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(150, 26);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(885, 82);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(175, 26);
            this.txtDienThoai.TabIndex = 12;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(370, 32);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(150, 26);
            this.dtpNgayNhap.TabIndex = 13;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(630, 32);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(150, 28);
            this.cboNhanVien.TabIndex = 14;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(100, 82);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(150, 28);
            this.cboNCC.TabIndex = 15;
            // 
            // gbChiTiet
            // 
            this.gbChiTiet.Controls.Add(this.btnXoaHang);
            this.gbChiTiet.Controls.Add(this.btnThemHang);
            this.gbChiTiet.Controls.Add(this.nudSoLuong);
            this.gbChiTiet.Controls.Add(this.txtThanhTien);
            this.gbChiTiet.Controls.Add(this.txtGiamGia);
            this.gbChiTiet.Controls.Add(this.txtDonGia);
            this.gbChiTiet.Controls.Add(this.txtTenNoiThat);
            this.gbChiTiet.Controls.Add(this.cboMaNoiThat);
            this.gbChiTiet.Controls.Add(this.label14);
            this.gbChiTiet.Controls.Add(this.label13);
            this.gbChiTiet.Controls.Add(this.label12);
            this.gbChiTiet.Controls.Add(this.label11);
            this.gbChiTiet.Controls.Add(this.label10);
            this.gbChiTiet.Controls.Add(this.label9);
            this.gbChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChiTiet.Location = new System.Drawing.Point(0, 135);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(1078, 135);
            this.gbChiTiet.TabIndex = 1;
            this.gbChiTiet.TabStop = false;
            this.gbChiTiet.Text = "Chi tiết mặt hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nội thất:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên nội thất:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(815, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số lượng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Đơn giá:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Giảm giá %:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(535, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thành tiền:";
            // 
            // cboMaNoiThat
            // 
            this.cboMaNoiThat.FormattingEnabled = true;
            this.cboMaNoiThat.Location = new System.Drawing.Point(120, 32);
            this.cboMaNoiThat.Name = "cboMaNoiThat";
            this.cboMaNoiThat.Size = new System.Drawing.Size(180, 28);
            this.cboMaNoiThat.TabIndex = 6;
            // 
            // txtTenNoiThat
            // 
            this.txtTenNoiThat.Location = new System.Drawing.Point(425, 32);
            this.txtTenNoiThat.Name = "txtTenNoiThat";
            this.txtTenNoiThat.Size = new System.Drawing.Size(355, 26);
            this.txtTenNoiThat.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(120, 82);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(180, 26);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(415, 82);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(90, 26);
            this.txtGiamGia.TabIndex = 9;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(620, 82);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(160, 26);
            this.txtThanhTien.TabIndex = 10;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(890, 32);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(170, 26);
            this.nudSoLuong.TabIndex = 11;
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHang.Location = new System.Drawing.Point(815, 81);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(115, 29);
            this.btnThemHang.TabIndex = 12;
            this.btnThemHang.Text = "+ Thêm hàng";
            this.btnThemHang.UseVisualStyleBackColor = false;
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.BackColor = System.Drawing.Color.Red;
            this.btnXoaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHang.Location = new System.Drawing.Point(945, 81);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(115, 29);
            this.btnXoaHang.TabIndex = 13;
            this.btnXoaHang.Text = "- Xóa hàng";
            this.btnXoaHang.UseVisualStyleBackColor = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Controls.Add(this.btnInHD);
            this.pnlBottom.Controls.Add(this.btnHuyHD);
            this.pnlBottom.Controls.Add(this.btnLuuHD);
            this.pnlBottom.Controls.Add(this.btnThemHD);
            this.pnlBottom.Controls.Add(this.txtTongTien);
            this.pnlBottom.Controls.Add(this.label15);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 589);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1078, 75);
            this.pnlBottom.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tổng tiền (VNĐ):";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(203, 31);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(210, 26);
            this.txtTongTien.TabIndex = 1;
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemHD.Location = new System.Drawing.Point(437, 30);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(96, 29);
            this.btnThemHD.TabIndex = 2;
            this.btnThemHD.Text = "Thêm HĐ";
            this.btnThemHD.UseVisualStyleBackColor = false;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuHD.Location = new System.Drawing.Point(560, 30);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(96, 29);
            this.btnLuuHD.TabIndex = 3;
            this.btnLuuHD.Text = "Lưu HĐ";
            this.btnLuuHD.UseVisualStyleBackColor = false;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnHuyHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuyHD.Location = new System.Drawing.Point(690, 30);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(96, 29);
            this.btnHuyHD.TabIndex = 4;
            this.btnHuyHD.Text = "Hủy HĐ";
            this.btnHuyHD.UseVisualStyleBackColor = false;
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInHD.Location = new System.Drawing.Point(820, 30);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(96, 29);
            this.btnInHD.TabIndex = 5;
            this.btnInHD.Text = "In HĐ";
            this.btnInHD.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Location = new System.Drawing.Point(950, 30);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(96, 29);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.AllowUserToAddRows = false;
            this.dgvChiTietNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNT,
            this.colTenNT,
            this.colSoLuong,
            this.colDonGia,
            this.colGiamGia,
            this.colThanhTien});
            this.dgvChiTietNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNhap.Location = new System.Drawing.Point(0, 270);
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.ReadOnly = true;
            this.dgvChiTietNhap.RowHeadersWidth = 62;
            this.dgvChiTietNhap.RowTemplate.Height = 28;
            this.dgvChiTietNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhap.Size = new System.Drawing.Size(1078, 319);
            this.dgvChiTietNhap.TabIndex = 3;
            // 
            // colMaNT
            // 
            this.colMaNT.FillWeight = 15F;
            this.colMaNT.HeaderText = "Mã nội thất";
            this.colMaNT.MinimumWidth = 8;
            this.colMaNT.Name = "colMaNT";
            this.colMaNT.ReadOnly = true;
            // 
            // colTenNT
            // 
            this.colTenNT.FillWeight = 30F;
            this.colTenNT.HeaderText = "Tên nội thất";
            this.colTenNT.MinimumWidth = 8;
            this.colTenNT.Name = "colTenNT";
            this.colTenNT.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 12F;
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.FillWeight = 15F;
            this.colDonGia.HeaderText = "Đơn giá nhập";
            this.colDonGia.MinimumWidth = 8;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colGiamGia
            // 
            this.colGiamGia.FillWeight = 10F;
            this.colGiamGia.HeaderText = "Giảm giá %";
            this.colGiamGia.MinimumWidth = 8;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.FillWeight = 18F;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // frmHoaDonNhap
            // 
            this.ClientSize = new System.Drawing.Size(1078, 664);
            this.Controls.Add(this.dgvChiTietNhap);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.gbChiTiet);
            this.Controls.Add(this.gbThongTinChung);
            this.Name = "frmHoaDonNhap";
            this.gbThongTinChung.ResumeLayout(false);
            this.gbThongTinChung.PerformLayout();
            this.gbChiTiet.ResumeLayout(false);
            this.gbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
