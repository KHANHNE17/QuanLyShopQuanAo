namespace QuanLyShopQuanAo.GUI
{
    partial class FormTrangChu
    {
        /// <summary>
        /// Biến thiết kế bắt buộc.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dọn dẹp các tài nguyên đang sử dụng.
        /// </summary>
        /// <param name="disposing">true nếu cần giải phóng tài nguyên managed; ngược lại false.</param>
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
        /// Phương thức hỗ trợ trình thiết kế - không sửa nội dung bằng trình soạn thảo mã.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle kieuTieuDe = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuO = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuXen = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuNgay = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle kieuTien = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTenPhanMem = new System.Windows.Forms.Label();
            this.lblKhauHieu = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslNgayGio = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslKhoangTrong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslTrangThaiKetNoi = new System.Windows.Forms.ToolStripStatusLabel();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuTrangChu = new System.Windows.Forms.Button();
            this.btnMenuSanPham = new System.Windows.Forms.Button();
            this.btnMenuDanhMuc = new System.Windows.Forms.Button();
            this.btnMenuThuongHieu = new System.Windows.Forms.Button();
            this.btnMenuKhachHang = new System.Windows.Forms.Button();
            this.btnMenuNhanVien = new System.Windows.Forms.Button();
            this.btnMenuNhaCungCap = new System.Windows.Forms.Button();
            this.btnMenuBanHang = new System.Windows.Forms.Button();
            this.btnMenuHoaDon = new System.Windows.Forms.Button();
            this.btnMenuPhieuNhap = new System.Windows.Forms.Button();
            this.btnMenuThongKe = new System.Windows.Forms.Button();
            this.btnMenuTaiKhoan = new System.Windows.Forms.Button();
            this.btnMenuDangXuat = new System.Windows.Forms.Button();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.pnlTrangChu = new System.Windows.Forms.Panel();
            this.tlpTrangChu = new System.Windows.Forms.TableLayoutPanel();
            this.btnCanhBaoTonKho = new System.Windows.Forms.Button();
            this.tlpThe = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTheSanPham = new System.Windows.Forms.Panel();
            this.lblTieuDeTheSanPham = new System.Windows.Forms.Label();
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.pnlVachSanPham = new System.Windows.Forms.Panel();
            this.pnlTheKhachHang = new System.Windows.Forms.Panel();
            this.lblTieuDeTheKhachHang = new System.Windows.Forms.Label();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.pnlVachKhachHang = new System.Windows.Forms.Panel();
            this.pnlTheHoaDon = new System.Windows.Forms.Panel();
            this.lblTieuDeTheHoaDon = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.pnlVachHoaDon = new System.Windows.Forms.Panel();
            this.pnlTheDoanhThu = new System.Windows.Forms.Panel();
            this.lblTieuDeTheDoanhThu = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.pnlVachDoanhThu = new System.Windows.Forms.Panel();
            this.pnlThaoTacNhanh = new System.Windows.Forms.Panel();
            this.flpThaoTacNhanh = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTieuDeThaoTac = new System.Windows.Forms.Label();
            this.btnNhanhBanHang = new System.Windows.Forms.Button();
            this.btnNhanhPhieuNhap = new System.Windows.Forms.Button();
            this.btnNhanhSanPham = new System.Windows.Forms.Button();
            this.btnNhanhKhachHang = new System.Windows.Forms.Button();
            this.btnNhanhHoaDon = new System.Windows.Forms.Button();
            this.btnNhanhThongKe = new System.Windows.Forms.Button();
            this.btnNhanhNhanVien = new System.Windows.Forms.Button();
            this.btnNhanhTaiKhoan = new System.Windows.Forms.Button();
            this.tlpDuoi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlBieuDoTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDeBieuDo = new System.Windows.Forms.Label();
            this.cboKhoangBieuDo = new System.Windows.Forms.ComboBox();
            this.pnlHoaDonGanDay = new System.Windows.Forms.Panel();
            this.dgvHoaDonGanDay = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHoaDonTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDeHoaDon = new System.Windows.Forms.Label();
            this.btnLamMoiTrangChu = new System.Windows.Forms.Button();
            this.tmrDongHo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonGanDay)).BeginInit();
            this.pnlBanner.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.pnlNoiDung.SuspendLayout();
            this.pnlTrangChu.SuspendLayout();
            this.tlpTrangChu.SuspendLayout();
            this.tlpThe.SuspendLayout();
            this.pnlTheSanPham.SuspendLayout();
            this.pnlVachSanPham.SuspendLayout();
            this.pnlTheKhachHang.SuspendLayout();
            this.pnlVachKhachHang.SuspendLayout();
            this.pnlTheHoaDon.SuspendLayout();
            this.pnlVachHoaDon.SuspendLayout();
            this.pnlTheDoanhThu.SuspendLayout();
            this.pnlVachDoanhThu.SuspendLayout();
            this.pnlThaoTacNhanh.SuspendLayout();
            this.flpThaoTacNhanh.SuspendLayout();
            this.tlpDuoi.SuspendLayout();
            this.pnlBieuDo.SuspendLayout();
            this.pnlBieuDoTieuDe.SuspendLayout();
            this.pnlHoaDonGanDay.SuspendLayout();
            this.pnlHoaDonTieuDe.SuspendLayout();
            this.SuspendLayout();
            //
            // Kiểu hiển thị của DataGridView hóa đơn gần đây
            //
            kieuTieuDe.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            kieuTieuDe.BackColor = System.Drawing.Color.FromArgb(93, 64, 55);
            kieuTieuDe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kieuTieuDe.ForeColor = System.Drawing.Color.White;
            kieuTieuDe.SelectionBackColor = System.Drawing.Color.FromArgb(93, 64, 55);
            kieuTieuDe.SelectionForeColor = System.Drawing.Color.White;
            kieuTieuDe.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            kieuO.BackColor = System.Drawing.Color.White;
            kieuO.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kieuO.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            kieuO.SelectionBackColor = System.Drawing.Color.FromArgb(245, 222, 179);
            kieuO.SelectionForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            kieuXen.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            kieuNgay.Format = "dd/MM/yyyy HH:mm";
            kieuNgay.NullValue = null;
            kieuTien.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            kieuTien.Format = "N0";
            kieuTien.NullValue = null;
            //
            // pnlBanner
            //
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Size = new System.Drawing.Size(1280, 70);
            this.pnlBanner.Controls.Add(this.lblLogo);
            this.pnlBanner.Controls.Add(this.lblTenPhanMem);
            this.pnlBanner.Controls.Add(this.lblKhauHieu);
            this.pnlBanner.Controls.Add(this.lblXinChao);
            this.pnlBanner.Controls.Add(this.lblVaiTro);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.TabIndex = 0;
            //
            // lblLogo
            //
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.lblLogo.Location = new System.Drawing.Point(14, 8);
            this.lblLogo.Size = new System.Drawing.Size(64, 54);
            this.lblLogo.Text = "👔";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.TabIndex = 0;
            //
            // lblTenPhanMem
            //
            this.lblTenPhanMem.AutoSize = true;
            this.lblTenPhanMem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenPhanMem.ForeColor = System.Drawing.Color.FromArgb(245, 222, 179);
            this.lblTenPhanMem.Location = new System.Drawing.Point(82, 10);
            this.lblTenPhanMem.Size = new System.Drawing.Size(279, 30);
            this.lblTenPhanMem.Text = "QUẢN LÝ SHOP QUẦN ÁO";
            this.lblTenPhanMem.Name = "lblTenPhanMem";
            this.lblTenPhanMem.TabIndex = 1;
            //
            // lblKhauHieu
            //
            this.lblKhauHieu.AutoSize = true;
            this.lblKhauHieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhauHieu.ForeColor = System.Drawing.Color.FromArgb(215, 204, 200);
            this.lblKhauHieu.Location = new System.Drawing.Point(84, 42);
            this.lblKhauHieu.Size = new System.Drawing.Size(225, 19);
            this.lblKhauHieu.Text = "Phong cách riêng – Quản lý dễ dàng";
            this.lblKhauHieu.Name = "lblKhauHieu";
            this.lblKhauHieu.TabIndex = 2;
            //
            // lblXinChao
            //
            this.lblXinChao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.lblXinChao.Location = new System.Drawing.Point(900, 12);
            this.lblXinChao.Size = new System.Drawing.Size(354, 25);
            this.lblXinChao.Text = "Xin chào";
            this.lblXinChao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.TabIndex = 3;
            //
            // lblVaiTro
            //
            this.lblVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(245, 222, 179);
            this.lblVaiTro.Location = new System.Drawing.Point(900, 40);
            this.lblVaiTro.Size = new System.Drawing.Size(354, 21);
            this.lblVaiTro.Text = "Vai trò";
            this.lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.TabIndex = 4;
            //
            // statusStrip
            //
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.statusStrip.Location = new System.Drawing.Point(0, 736);
            this.statusStrip.Size = new System.Drawing.Size(1280, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                        this.tslNgayGio,
                        this.tslKhoangTrong,
                        this.tslTrangThaiKetNoi});
            this.statusStrip.Name = "statusStrip";
            //
            // tslNgayGio
            //
            this.tslNgayGio.ForeColor = System.Drawing.Color.FromArgb(255, 248, 240);
            this.tslNgayGio.Size = new System.Drawing.Size(190, 19);
            this.tslNgayGio.Text = "Ngày: --/--/----   Giờ: --:--:--";
            this.tslNgayGio.Name = "tslNgayGio";
            //
            // tslKhoangTrong
            //
            this.tslKhoangTrong.ForeColor = System.Drawing.Color.FromArgb(215, 204, 200);
            this.tslKhoangTrong.Size = new System.Drawing.Size(840, 19);
            this.tslKhoangTrong.Spring = true;
            this.tslKhoangTrong.Text = "Quản Lý Shop Quần Áo  •  Chúc bạn một ngày làm việc hiệu quả!";
            this.tslKhoangTrong.Name = "tslKhoangTrong";
            //
            // tslTrangThaiKetNoi
            //
            this.tslTrangThaiKetNoi.ForeColor = System.Drawing.Color.FromArgb(165, 214, 167);
            this.tslTrangThaiKetNoi.Size = new System.Drawing.Size(120, 19);
            this.tslTrangThaiKetNoi.Text = "Kết nối: Online";
            this.tslTrangThaiKetNoi.Name = "tslTrangThaiKetNoi";
            //
            // flpMenu
            //
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(0, 70);
            this.flpMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpMenu.Size = new System.Drawing.Size(210, 666);
            this.flpMenu.WrapContents = false;
            this.flpMenu.Controls.Add(this.btnMenuTrangChu);
            this.flpMenu.Controls.Add(this.btnMenuSanPham);
            this.flpMenu.Controls.Add(this.btnMenuDanhMuc);
            this.flpMenu.Controls.Add(this.btnMenuThuongHieu);
            this.flpMenu.Controls.Add(this.btnMenuKhachHang);
            this.flpMenu.Controls.Add(this.btnMenuNhanVien);
            this.flpMenu.Controls.Add(this.btnMenuNhaCungCap);
            this.flpMenu.Controls.Add(this.btnMenuBanHang);
            this.flpMenu.Controls.Add(this.btnMenuHoaDon);
            this.flpMenu.Controls.Add(this.btnMenuPhieuNhap);
            this.flpMenu.Controls.Add(this.btnMenuThongKe);
            this.flpMenu.Controls.Add(this.btnMenuTaiKhoan);
            this.flpMenu.Controls.Add(this.btnMenuDangXuat);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.TabIndex = 2;
            //
            // btnMenuTrangChu
            //
            this.btnMenuTrangChu.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuTrangChu.FlatAppearance.BorderSize = 0;
            this.btnMenuTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTrangChu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuTrangChu.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuTrangChu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuTrangChu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuTrangChu.Size = new System.Drawing.Size(210, 44);
            this.btnMenuTrangChu.Tag = "TrangChu";
            this.btnMenuTrangChu.Text = "🏠  Trang chủ";
            this.btnMenuTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTrangChu.UseVisualStyleBackColor = false;
            this.btnMenuTrangChu.Name = "btnMenuTrangChu";
            this.btnMenuTrangChu.TabIndex = 0;
            this.btnMenuTrangChu.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuSanPham
            //
            this.btnMenuSanPham.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSanPham.FlatAppearance.BorderSize = 0;
            this.btnMenuSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuSanPham.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuSanPham.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuSanPham.Size = new System.Drawing.Size(210, 44);
            this.btnMenuSanPham.Tag = "SanPham";
            this.btnMenuSanPham.Text = "👕  Sản phẩm";
            this.btnMenuSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSanPham.UseVisualStyleBackColor = false;
            this.btnMenuSanPham.Name = "btnMenuSanPham";
            this.btnMenuSanPham.TabIndex = 1;
            this.btnMenuSanPham.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuDanhMuc
            //
            this.btnMenuDanhMuc.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnMenuDanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuDanhMuc.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuDanhMuc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuDanhMuc.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuDanhMuc.Size = new System.Drawing.Size(210, 44);
            this.btnMenuDanhMuc.Tag = "DanhMuc";
            this.btnMenuDanhMuc.Text = "🗂  Danh mục";
            this.btnMenuDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDanhMuc.UseVisualStyleBackColor = false;
            this.btnMenuDanhMuc.Name = "btnMenuDanhMuc";
            this.btnMenuDanhMuc.TabIndex = 2;
            this.btnMenuDanhMuc.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuThuongHieu
            //
            this.btnMenuThuongHieu.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuThuongHieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuThuongHieu.FlatAppearance.BorderSize = 0;
            this.btnMenuThuongHieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuThuongHieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuThuongHieu.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuThuongHieu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuThuongHieu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuThuongHieu.Size = new System.Drawing.Size(210, 44);
            this.btnMenuThuongHieu.Tag = "ThuongHieu";
            this.btnMenuThuongHieu.Text = "🏷  Thương hiệu";
            this.btnMenuThuongHieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuThuongHieu.UseVisualStyleBackColor = false;
            this.btnMenuThuongHieu.Name = "btnMenuThuongHieu";
            this.btnMenuThuongHieu.TabIndex = 3;
            this.btnMenuThuongHieu.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuKhachHang
            //
            this.btnMenuKhachHang.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuKhachHang.FlatAppearance.BorderSize = 0;
            this.btnMenuKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuKhachHang.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuKhachHang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuKhachHang.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuKhachHang.Size = new System.Drawing.Size(210, 44);
            this.btnMenuKhachHang.Tag = "KhachHang";
            this.btnMenuKhachHang.Text = "👥  Khách hàng";
            this.btnMenuKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuKhachHang.UseVisualStyleBackColor = false;
            this.btnMenuKhachHang.Name = "btnMenuKhachHang";
            this.btnMenuKhachHang.TabIndex = 4;
            this.btnMenuKhachHang.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuNhanVien
            //
            this.btnMenuNhanVien.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuNhanVien.FlatAppearance.BorderSize = 0;
            this.btnMenuNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuNhanVien.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuNhanVien.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuNhanVien.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuNhanVien.Size = new System.Drawing.Size(210, 44);
            this.btnMenuNhanVien.Tag = "NhanVien";
            this.btnMenuNhanVien.Text = "👤  Nhân viên";
            this.btnMenuNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNhanVien.UseVisualStyleBackColor = false;
            this.btnMenuNhanVien.Name = "btnMenuNhanVien";
            this.btnMenuNhanVien.TabIndex = 5;
            this.btnMenuNhanVien.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuNhaCungCap
            //
            this.btnMenuNhaCungCap.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnMenuNhaCungCap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuNhaCungCap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuNhaCungCap.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuNhaCungCap.Size = new System.Drawing.Size(210, 44);
            this.btnMenuNhaCungCap.Tag = "NhaCungCap";
            this.btnMenuNhaCungCap.Text = "🚚  Nhà cung cấp";
            this.btnMenuNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNhaCungCap.UseVisualStyleBackColor = false;
            this.btnMenuNhaCungCap.Name = "btnMenuNhaCungCap";
            this.btnMenuNhaCungCap.TabIndex = 6;
            this.btnMenuNhaCungCap.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuBanHang
            //
            this.btnMenuBanHang.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBanHang.FlatAppearance.BorderSize = 0;
            this.btnMenuBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBanHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuBanHang.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuBanHang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuBanHang.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuBanHang.Size = new System.Drawing.Size(210, 44);
            this.btnMenuBanHang.Tag = "BanHang";
            this.btnMenuBanHang.Text = "🛒  Bán hàng";
            this.btnMenuBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBanHang.UseVisualStyleBackColor = false;
            this.btnMenuBanHang.Name = "btnMenuBanHang";
            this.btnMenuBanHang.TabIndex = 7;
            this.btnMenuBanHang.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuHoaDon
            //
            this.btnMenuHoaDon.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuHoaDon.FlatAppearance.BorderSize = 0;
            this.btnMenuHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuHoaDon.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuHoaDon.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuHoaDon.Size = new System.Drawing.Size(210, 44);
            this.btnMenuHoaDon.Tag = "HoaDon";
            this.btnMenuHoaDon.Text = "🧾  Hóa đơn";
            this.btnMenuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHoaDon.UseVisualStyleBackColor = false;
            this.btnMenuHoaDon.Name = "btnMenuHoaDon";
            this.btnMenuHoaDon.TabIndex = 8;
            this.btnMenuHoaDon.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuPhieuNhap
            //
            this.btnMenuPhieuNhap.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnMenuPhieuNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuPhieuNhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuPhieuNhap.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuPhieuNhap.Size = new System.Drawing.Size(210, 44);
            this.btnMenuPhieuNhap.Tag = "PhieuNhap";
            this.btnMenuPhieuNhap.Text = "📦  Phiếu nhập";
            this.btnMenuPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPhieuNhap.UseVisualStyleBackColor = false;
            this.btnMenuPhieuNhap.Name = "btnMenuPhieuNhap";
            this.btnMenuPhieuNhap.TabIndex = 9;
            this.btnMenuPhieuNhap.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuThongKe
            //
            this.btnMenuThongKe.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuThongKe.FlatAppearance.BorderSize = 0;
            this.btnMenuThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuThongKe.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuThongKe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuThongKe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuThongKe.Size = new System.Drawing.Size(210, 44);
            this.btnMenuThongKe.Tag = "ThongKe";
            this.btnMenuThongKe.Text = "📊  Thống kê";
            this.btnMenuThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuThongKe.UseVisualStyleBackColor = false;
            this.btnMenuThongKe.Name = "btnMenuThongKe";
            this.btnMenuThongKe.TabIndex = 10;
            this.btnMenuThongKe.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuTaiKhoan
            //
            this.btnMenuTaiKhoan.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnMenuTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuTaiKhoan.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuTaiKhoan.Size = new System.Drawing.Size(210, 44);
            this.btnMenuTaiKhoan.Tag = "TaiKhoan";
            this.btnMenuTaiKhoan.Text = "🔑  Tài khoản";
            this.btnMenuTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTaiKhoan.UseVisualStyleBackColor = false;
            this.btnMenuTaiKhoan.Name = "btnMenuTaiKhoan";
            this.btnMenuTaiKhoan.TabIndex = 11;
            this.btnMenuTaiKhoan.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnMenuDangXuat
            //
            this.btnMenuDangXuat.BackColor = System.Drawing.Color.FromArgb(78, 52, 46);
            this.btnMenuDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDangXuat.FlatAppearance.BorderSize = 0;
            this.btnMenuDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 76, 65);
            this.btnMenuDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMenuDangXuat.ForeColor = System.Drawing.Color.FromArgb(239, 235, 233);
            this.btnMenuDangXuat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnMenuDangXuat.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMenuDangXuat.Size = new System.Drawing.Size(210, 44);
            this.btnMenuDangXuat.Tag = "DangXuat";
            this.btnMenuDangXuat.Text = "🚪  Đăng xuất";
            this.btnMenuDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDangXuat.UseVisualStyleBackColor = false;
            this.btnMenuDangXuat.Name = "btnMenuDangXuat";
            this.btnMenuDangXuat.TabIndex = 12;
            this.btnMenuDangXuat.Click += new System.EventHandler(this.btnMenuDangXuat_Click);
            //
            // pnlNoiDung
            //
            this.pnlNoiDung.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(210, 70);
            this.pnlNoiDung.Size = new System.Drawing.Size(1070, 666);
            this.pnlNoiDung.Controls.Add(this.pnlTrangChu);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.TabIndex = 3;
            //
            // pnlTrangChu
            //
            this.pnlTrangChu.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrangChu.Location = new System.Drawing.Point(0, 0);
            this.pnlTrangChu.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlTrangChu.Size = new System.Drawing.Size(1070, 666);
            this.pnlTrangChu.Controls.Add(this.tlpTrangChu);
            this.pnlTrangChu.Name = "pnlTrangChu";
            this.pnlTrangChu.TabIndex = 0;
            //
            // tlpTrangChu
            //
            this.tlpTrangChu.ColumnCount = 1;
            this.tlpTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTrangChu.Location = new System.Drawing.Point(12, 12);
            this.tlpTrangChu.RowCount = 4;
            this.tlpTrangChu.Size = new System.Drawing.Size(1046, 642);
            this.tlpTrangChu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrangChu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpTrangChu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpTrangChu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTrangChu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrangChu.Controls.Add(this.btnCanhBaoTonKho, 0, 0);
            this.tlpTrangChu.Controls.Add(this.tlpThe, 0, 1);
            this.tlpTrangChu.Controls.Add(this.pnlThaoTacNhanh, 0, 2);
            this.tlpTrangChu.Controls.Add(this.tlpDuoi, 0, 3);
            this.tlpTrangChu.Name = "tlpTrangChu";
            this.tlpTrangChu.TabIndex = 0;
            //
            // btnCanhBaoTonKho
            //
            this.btnCanhBaoTonKho.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.btnCanhBaoTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanhBaoTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCanhBaoTonKho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 183, 77);
            this.btnCanhBaoTonKho.FlatAppearance.BorderSize = 1;
            this.btnCanhBaoTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanhBaoTonKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCanhBaoTonKho.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.btnCanhBaoTonKho.Location = new System.Drawing.Point(0, 0);
            this.btnCanhBaoTonKho.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnCanhBaoTonKho.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCanhBaoTonKho.Size = new System.Drawing.Size(1046, 36);
            this.btnCanhBaoTonKho.Text = "Đang kiểm tra tồn kho...";
            this.btnCanhBaoTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanhBaoTonKho.UseVisualStyleBackColor = false;
            this.btnCanhBaoTonKho.Name = "btnCanhBaoTonKho";
            this.btnCanhBaoTonKho.TabIndex = 0;
            this.btnCanhBaoTonKho.Click += new System.EventHandler(this.btnCanhBaoTonKho_Click);
            //
            // tlpThe
            //
            this.tlpThe.ColumnCount = 4;
            this.tlpThe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThe.Location = new System.Drawing.Point(0, 0);
            this.tlpThe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpThe.RowCount = 1;
            this.tlpThe.Size = new System.Drawing.Size(1046, 110);
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpThe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThe.Controls.Add(this.pnlTheSanPham, 0, 0);
            this.tlpThe.Controls.Add(this.pnlTheKhachHang, 1, 0);
            this.tlpThe.Controls.Add(this.pnlTheHoaDon, 2, 0);
            this.tlpThe.Controls.Add(this.pnlTheDoanhThu, 3, 0);
            this.tlpThe.Name = "tlpThe";
            this.tlpThe.TabIndex = 1;
            //
            // pnlTheSanPham
            //
            this.pnlTheSanPham.BackColor = System.Drawing.Color.White;
            this.pnlTheSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlTheSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlTheSanPham.Size = new System.Drawing.Size(250, 100);
            this.pnlTheSanPham.Controls.Add(this.lblTieuDeTheSanPham);
            this.pnlTheSanPham.Controls.Add(this.lblSoSanPham);
            this.pnlTheSanPham.Controls.Add(this.pnlVachSanPham);
            this.pnlTheSanPham.Name = "pnlTheSanPham";
            this.pnlTheSanPham.TabIndex = 0;
            //
            // lblTieuDeTheSanPham
            //
            this.lblTieuDeTheSanPham.AutoSize = true;
            this.lblTieuDeTheSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheSanPham.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheSanPham.Location = new System.Drawing.Point(22, 16);
            this.lblTieuDeTheSanPham.Size = new System.Drawing.Size(120, 19);
            this.lblTieuDeTheSanPham.Text = "TỔNG SẢN PHẨM";
            this.lblTieuDeTheSanPham.Name = "lblTieuDeTheSanPham";
            this.lblTieuDeTheSanPham.TabIndex = 0;
            //
            // lblSoSanPham
            //
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoSanPham.ForeColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.lblSoSanPham.Location = new System.Drawing.Point(20, 46);
            this.lblSoSanPham.Size = new System.Drawing.Size(32, 37);
            this.lblSoSanPham.Text = "0";
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.TabIndex = 1;
            //
            // pnlVachSanPham
            //
            this.pnlVachSanPham.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.pnlVachSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachSanPham.Location = new System.Drawing.Point(0, 0);
            this.pnlVachSanPham.Size = new System.Drawing.Size(8, 100);
            this.pnlVachSanPham.Name = "pnlVachSanPham";
            this.pnlVachSanPham.TabIndex = 2;
            //
            // pnlTheKhachHang
            //
            this.pnlTheKhachHang.BackColor = System.Drawing.Color.White;
            this.pnlTheKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlTheKhachHang.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlTheKhachHang.Size = new System.Drawing.Size(250, 100);
            this.pnlTheKhachHang.Controls.Add(this.lblTieuDeTheKhachHang);
            this.pnlTheKhachHang.Controls.Add(this.lblSoKhachHang);
            this.pnlTheKhachHang.Controls.Add(this.pnlVachKhachHang);
            this.pnlTheKhachHang.Name = "pnlTheKhachHang";
            this.pnlTheKhachHang.TabIndex = 1;
            //
            // lblTieuDeTheKhachHang
            //
            this.lblTieuDeTheKhachHang.AutoSize = true;
            this.lblTieuDeTheKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheKhachHang.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheKhachHang.Location = new System.Drawing.Point(22, 16);
            this.lblTieuDeTheKhachHang.Size = new System.Drawing.Size(120, 19);
            this.lblTieuDeTheKhachHang.Text = "SỐ KHÁCH HÀNG";
            this.lblTieuDeTheKhachHang.Name = "lblTieuDeTheKhachHang";
            this.lblTieuDeTheKhachHang.TabIndex = 0;
            //
            // lblSoKhachHang
            //
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoKhachHang.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.lblSoKhachHang.Location = new System.Drawing.Point(20, 46);
            this.lblSoKhachHang.Size = new System.Drawing.Size(32, 37);
            this.lblSoKhachHang.Text = "0";
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.TabIndex = 1;
            //
            // pnlVachKhachHang
            //
            this.pnlVachKhachHang.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.pnlVachKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlVachKhachHang.Size = new System.Drawing.Size(8, 100);
            this.pnlVachKhachHang.Name = "pnlVachKhachHang";
            this.pnlVachKhachHang.TabIndex = 2;
            //
            // pnlTheHoaDon
            //
            this.pnlTheHoaDon.BackColor = System.Drawing.Color.White;
            this.pnlTheHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnlTheHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlTheHoaDon.Size = new System.Drawing.Size(250, 100);
            this.pnlTheHoaDon.Controls.Add(this.lblTieuDeTheHoaDon);
            this.pnlTheHoaDon.Controls.Add(this.lblSoHoaDon);
            this.pnlTheHoaDon.Controls.Add(this.pnlVachHoaDon);
            this.pnlTheHoaDon.Name = "pnlTheHoaDon";
            this.pnlTheHoaDon.TabIndex = 2;
            //
            // lblTieuDeTheHoaDon
            //
            this.lblTieuDeTheHoaDon.AutoSize = true;
            this.lblTieuDeTheHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheHoaDon.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheHoaDon.Location = new System.Drawing.Point(22, 16);
            this.lblTieuDeTheHoaDon.Size = new System.Drawing.Size(120, 19);
            this.lblTieuDeTheHoaDon.Text = "SỐ HÓA ĐƠN";
            this.lblTieuDeTheHoaDon.Name = "lblTieuDeTheHoaDon";
            this.lblTieuDeTheHoaDon.TabIndex = 0;
            //
            // lblSoHoaDon
            //
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.lblSoHoaDon.Location = new System.Drawing.Point(20, 46);
            this.lblSoHoaDon.Size = new System.Drawing.Size(32, 37);
            this.lblSoHoaDon.Text = "0";
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.TabIndex = 1;
            //
            // pnlVachHoaDon
            //
            this.pnlVachHoaDon.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.pnlVachHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.pnlVachHoaDon.Size = new System.Drawing.Size(8, 100);
            this.pnlVachHoaDon.Name = "pnlVachHoaDon";
            this.pnlVachHoaDon.TabIndex = 2;
            //
            // pnlTheDoanhThu
            //
            this.pnlTheDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlTheDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlTheDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlTheDoanhThu.Size = new System.Drawing.Size(250, 100);
            this.pnlTheDoanhThu.Controls.Add(this.lblTieuDeTheDoanhThu);
            this.pnlTheDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlTheDoanhThu.Controls.Add(this.pnlVachDoanhThu);
            this.pnlTheDoanhThu.Name = "pnlTheDoanhThu";
            this.pnlTheDoanhThu.TabIndex = 3;
            //
            // lblTieuDeTheDoanhThu
            //
            this.lblTieuDeTheDoanhThu.AutoSize = true;
            this.lblTieuDeTheDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeTheDoanhThu.ForeColor = System.Drawing.Color.FromArgb(121, 85, 72);
            this.lblTieuDeTheDoanhThu.Location = new System.Drawing.Point(22, 16);
            this.lblTieuDeTheDoanhThu.Size = new System.Drawing.Size(120, 19);
            this.lblTieuDeTheDoanhThu.Text = "DOANH THU";
            this.lblTieuDeTheDoanhThu.Name = "lblTieuDeTheDoanhThu";
            this.lblTieuDeTheDoanhThu.TabIndex = 0;
            //
            // lblDoanhThu
            //
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(173, 20, 87);
            this.lblDoanhThu.Location = new System.Drawing.Point(20, 46);
            this.lblDoanhThu.Size = new System.Drawing.Size(32, 37);
            this.lblDoanhThu.Text = "0";
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.TabIndex = 1;
            //
            // pnlVachDoanhThu
            //
            this.pnlVachDoanhThu.BackColor = System.Drawing.Color.FromArgb(173, 20, 87);
            this.pnlVachDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVachDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlVachDoanhThu.Size = new System.Drawing.Size(8, 100);
            this.pnlVachDoanhThu.Name = "pnlVachDoanhThu";
            this.pnlVachDoanhThu.TabIndex = 2;
            //
            // pnlThaoTacNhanh
            //
            this.pnlThaoTacNhanh.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.pnlThaoTacNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThaoTacNhanh.Location = new System.Drawing.Point(0, 110);
            this.pnlThaoTacNhanh.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlThaoTacNhanh.Size = new System.Drawing.Size(1046, 92);
            this.pnlThaoTacNhanh.Controls.Add(this.flpThaoTacNhanh);
            this.pnlThaoTacNhanh.Controls.Add(this.lblTieuDeThaoTac);
            this.pnlThaoTacNhanh.Name = "pnlThaoTacNhanh";
            this.pnlThaoTacNhanh.TabIndex = 2;
            //
            // flpThaoTacNhanh
            //
            this.flpThaoTacNhanh.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.flpThaoTacNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpThaoTacNhanh.Location = new System.Drawing.Point(0, 24);
            this.flpThaoTacNhanh.Size = new System.Drawing.Size(1046, 68);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhBanHang);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhPhieuNhap);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhSanPham);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhKhachHang);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhHoaDon);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhThongKe);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhNhanVien);
            this.flpThaoTacNhanh.Controls.Add(this.btnNhanhTaiKhoan);
            this.flpThaoTacNhanh.Name = "flpThaoTacNhanh";
            this.flpThaoTacNhanh.TabIndex = 0;
            //
            // lblTieuDeThaoTac
            //
            this.lblTieuDeThaoTac.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.lblTieuDeThaoTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeThaoTac.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeThaoTac.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeThaoTac.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeThaoTac.Size = new System.Drawing.Size(1046, 24);
            this.lblTieuDeThaoTac.Text = "THAO TÁC NHANH";
            this.lblTieuDeThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeThaoTac.Name = "lblTieuDeThaoTac";
            this.lblTieuDeThaoTac.TabIndex = 1;
            //
            // btnNhanhBanHang
            //
            this.btnNhanhBanHang.BackColor = System.Drawing.Color.FromArgb(56, 142, 60);
            this.btnNhanhBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhBanHang.FlatAppearance.BorderSize = 0;
            this.btnNhanhBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhBanHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhBanHang.ForeColor = System.Drawing.Color.White;
            this.btnNhanhBanHang.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhBanHang.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhBanHang.Tag = "BanHang";
            this.btnNhanhBanHang.Text = "🛒\r\nBán hàng";
            this.btnNhanhBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhBanHang.UseVisualStyleBackColor = false;
            this.btnNhanhBanHang.Name = "btnNhanhBanHang";
            this.btnNhanhBanHang.TabIndex = 0;
            this.btnNhanhBanHang.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhPhieuNhap
            //
            this.btnNhanhPhieuNhap.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnNhanhPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnNhanhPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhanhPhieuNhap.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhPhieuNhap.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhPhieuNhap.Tag = "PhieuNhap";
            this.btnNhanhPhieuNhap.Text = "📦\r\nNhập hàng";
            this.btnNhanhPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhPhieuNhap.UseVisualStyleBackColor = false;
            this.btnNhanhPhieuNhap.Name = "btnNhanhPhieuNhap";
            this.btnNhanhPhieuNhap.TabIndex = 1;
            this.btnNhanhPhieuNhap.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhSanPham
            //
            this.btnNhanhSanPham.BackColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.btnNhanhSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhSanPham.FlatAppearance.BorderSize = 0;
            this.btnNhanhSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhSanPham.ForeColor = System.Drawing.Color.White;
            this.btnNhanhSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhSanPham.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhSanPham.Tag = "SanPham";
            this.btnNhanhSanPham.Text = "👕\r\nSản phẩm";
            this.btnNhanhSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhSanPham.UseVisualStyleBackColor = false;
            this.btnNhanhSanPham.Name = "btnNhanhSanPham";
            this.btnNhanhSanPham.TabIndex = 2;
            this.btnNhanhSanPham.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhKhachHang
            //
            this.btnNhanhKhachHang.BackColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.btnNhanhKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhKhachHang.FlatAppearance.BorderSize = 0;
            this.btnNhanhKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnNhanhKhachHang.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhKhachHang.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhKhachHang.Tag = "KhachHang";
            this.btnNhanhKhachHang.Text = "👥\r\nKhách hàng";
            this.btnNhanhKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhKhachHang.UseVisualStyleBackColor = false;
            this.btnNhanhKhachHang.Name = "btnNhanhKhachHang";
            this.btnNhanhKhachHang.TabIndex = 3;
            this.btnNhanhKhachHang.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhHoaDon
            //
            this.btnNhanhHoaDon.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.btnNhanhHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhHoaDon.FlatAppearance.BorderSize = 0;
            this.btnNhanhHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnNhanhHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhHoaDon.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhHoaDon.Tag = "HoaDon";
            this.btnNhanhHoaDon.Text = "🧾\r\nHóa đơn";
            this.btnNhanhHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhHoaDon.UseVisualStyleBackColor = false;
            this.btnNhanhHoaDon.Name = "btnNhanhHoaDon";
            this.btnNhanhHoaDon.TabIndex = 4;
            this.btnNhanhHoaDon.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhThongKe
            //
            this.btnNhanhThongKe.BackColor = System.Drawing.Color.FromArgb(173, 20, 87);
            this.btnNhanhThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhThongKe.FlatAppearance.BorderSize = 0;
            this.btnNhanhThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhThongKe.ForeColor = System.Drawing.Color.White;
            this.btnNhanhThongKe.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhThongKe.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhThongKe.Tag = "ThongKe";
            this.btnNhanhThongKe.Text = "📊\r\nThống kê";
            this.btnNhanhThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhThongKe.UseVisualStyleBackColor = false;
            this.btnNhanhThongKe.Name = "btnNhanhThongKe";
            this.btnNhanhThongKe.TabIndex = 5;
            this.btnNhanhThongKe.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhNhanVien
            //
            this.btnNhanhNhanVien.BackColor = System.Drawing.Color.FromArgb(94, 53, 177);
            this.btnNhanhNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanhNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanhNhanVien.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhNhanVien.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhNhanVien.Tag = "NhanVien";
            this.btnNhanhNhanVien.Text = "👤\r\nNhân viên";
            this.btnNhanhNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanhNhanVien.Name = "btnNhanhNhanVien";
            this.btnNhanhNhanVien.TabIndex = 6;
            this.btnNhanhNhanVien.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // btnNhanhTaiKhoan
            //
            this.btnNhanhTaiKhoan.BackColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.btnNhanhTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanhTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnNhanhTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanhTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanhTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnNhanhTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhanhTaiKhoan.Size = new System.Drawing.Size(118, 66);
            this.btnNhanhTaiKhoan.Tag = "TaiKhoan";
            this.btnNhanhTaiKhoan.Text = "🔑\r\nTài khoản";
            this.btnNhanhTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanhTaiKhoan.UseVisualStyleBackColor = false;
            this.btnNhanhTaiKhoan.Name = "btnNhanhTaiKhoan";
            this.btnNhanhTaiKhoan.TabIndex = 7;
            this.btnNhanhTaiKhoan.Click += new System.EventHandler(this.btnNhanh_Click);
            //
            // tlpDuoi
            //
            this.tlpDuoi.ColumnCount = 2;
            this.tlpDuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDuoi.Location = new System.Drawing.Point(0, 210);
            this.tlpDuoi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpDuoi.RowCount = 1;
            this.tlpDuoi.Size = new System.Drawing.Size(1046, 388);
            this.tlpDuoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tlpDuoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpDuoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDuoi.Controls.Add(this.pnlBieuDo, 0, 0);
            this.tlpDuoi.Controls.Add(this.pnlHoaDonGanDay, 1, 0);
            this.tlpDuoi.Name = "tlpDuoi";
            this.tlpDuoi.TabIndex = 3;
            //
            // pnlBieuDo
            //
            this.pnlBieuDo.BackColor = System.Drawing.Color.White;
            this.pnlBieuDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBieuDo.Location = new System.Drawing.Point(0, 0);
            this.pnlBieuDo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlBieuDo.Size = new System.Drawing.Size(597, 532);
            this.pnlBieuDo.Controls.Add(this.chartDoanhThu);
            this.pnlBieuDo.Controls.Add(this.pnlBieuDoTieuDe);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.TabIndex = 0;
            //
            // chartDoanhThu
            //
            this.chartDoanhThu.BackColor = System.Drawing.Color.White;
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 46);
            this.chartDoanhThu.Size = new System.Drawing.Size(597, 486);
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Format = "#,##0";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.FromArgb(184, 87, 26);
            series1.IsValueShownAsLabel = false;
            series1.Name = "DoanhThu";
            series1.ToolTip = "#VALX: #VAL{N0} đ";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.TabIndex = 0;
            //
            // pnlBieuDoTieuDe
            //
            this.pnlBieuDoTieuDe.BackColor = System.Drawing.Color.White;
            this.pnlBieuDoTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBieuDoTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlBieuDoTieuDe.Size = new System.Drawing.Size(597, 46);
            this.pnlBieuDoTieuDe.Controls.Add(this.lblTieuDeBieuDo);
            this.pnlBieuDoTieuDe.Controls.Add(this.cboKhoangBieuDo);
            this.pnlBieuDoTieuDe.Name = "pnlBieuDoTieuDe";
            this.pnlBieuDoTieuDe.TabIndex = 1;
            //
            // lblTieuDeBieuDo
            //
            this.lblTieuDeBieuDo.AutoSize = true;
            this.lblTieuDeBieuDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeBieuDo.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeBieuDo.Location = new System.Drawing.Point(14, 12);
            this.lblTieuDeBieuDo.Size = new System.Drawing.Size(125, 21);
            this.lblTieuDeBieuDo.Text = "Biểu đồ doanh thu";
            this.lblTieuDeBieuDo.Name = "lblTieuDeBieuDo";
            this.lblTieuDeBieuDo.TabIndex = 0;
            //
            // cboKhoangBieuDo
            //
            this.cboKhoangBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKhoangBieuDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoangBieuDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKhoangBieuDo.FormattingEnabled = true;
            this.cboKhoangBieuDo.Location = new System.Drawing.Point(415, 9);
            this.cboKhoangBieuDo.Size = new System.Drawing.Size(170, 25);
            this.cboKhoangBieuDo.Items.AddRange(new object[] {
                        "7 ngày gần nhất",
                        "30 ngày gần nhất",
                        "12 tháng gần nhất"});
            this.cboKhoangBieuDo.Name = "cboKhoangBieuDo";
            this.cboKhoangBieuDo.TabIndex = 1;
            this.cboKhoangBieuDo.SelectedIndexChanged += new System.EventHandler(this.cboKhoangBieuDo_SelectedIndexChanged);
            //
            // pnlHoaDonGanDay
            //
            this.pnlHoaDonGanDay.BackColor = System.Drawing.Color.White;
            this.pnlHoaDonGanDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHoaDonGanDay.Location = new System.Drawing.Point(607, 0);
            this.pnlHoaDonGanDay.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlHoaDonGanDay.Size = new System.Drawing.Size(439, 532);
            this.pnlHoaDonGanDay.Controls.Add(this.dgvHoaDonGanDay);
            this.pnlHoaDonGanDay.Controls.Add(this.pnlHoaDonTieuDe);
            this.pnlHoaDonGanDay.Name = "pnlHoaDonGanDay";
            this.pnlHoaDonGanDay.TabIndex = 1;
            //
            // dgvHoaDonGanDay
            //
            this.dgvHoaDonGanDay.AllowUserToAddRows = false;
            this.dgvHoaDonGanDay.AllowUserToDeleteRows = false;
            this.dgvHoaDonGanDay.AllowUserToResizeRows = false;
            this.dgvHoaDonGanDay.AlternatingRowsDefaultCellStyle = kieuXen;
            this.dgvHoaDonGanDay.AutoGenerateColumns = false;
            this.dgvHoaDonGanDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonGanDay.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonGanDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDonGanDay.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvHoaDonGanDay.ColumnHeadersHeight = 34;
            this.dgvHoaDonGanDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonGanDay.DefaultCellStyle = kieuO;
            this.dgvHoaDonGanDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonGanDay.EnableHeadersVisualStyles = false;
            this.dgvHoaDonGanDay.GridColor = System.Drawing.Color.FromArgb(230, 224, 216);
            this.dgvHoaDonGanDay.Location = new System.Drawing.Point(0, 46);
            this.dgvHoaDonGanDay.MultiSelect = false;
            this.dgvHoaDonGanDay.ReadOnly = true;
            this.dgvHoaDonGanDay.RowHeadersVisible = false;
            this.dgvHoaDonGanDay.RowTemplate.Height = 30;
            this.dgvHoaDonGanDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonGanDay.Size = new System.Drawing.Size(439, 486);
            this.dgvHoaDonGanDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colMaHoaDon,
                        this.colNgayLap,
                        this.colKhachHang,
                        this.colThanhTien,
                        this.colTrangThai});
            this.dgvHoaDonGanDay.Name = "dgvHoaDonGanDay";
            this.dgvHoaDonGanDay.TabIndex = 0;
            this.dgvHoaDonGanDay.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoaDonGanDay_CellFormatting);
            //
            // colMaHoaDon
            //
            this.colMaHoaDon.DataPropertyName = "MaHoaDon";
            this.colMaHoaDon.FillWeight = 34F;
            this.colMaHoaDon.HeaderText = "Mã HĐ";
            this.colMaHoaDon.ReadOnly = true;
            this.colMaHoaDon.Name = "colMaHoaDon";
            //
            // colNgayLap
            //
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.DefaultCellStyle = kieuNgay;
            this.colNgayLap.FillWeight = 26F;
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.ReadOnly = true;
            this.colNgayLap.Name = "colNgayLap";
            //
            // colKhachHang
            //
            this.colKhachHang.DataPropertyName = "TenKhachHang";
            this.colKhachHang.FillWeight = 26F;
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.ReadOnly = true;
            this.colKhachHang.Name = "colKhachHang";
            //
            // colThanhTien
            //
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.DefaultCellStyle = kieuTien;
            this.colThanhTien.FillWeight = 22F;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Name = "colThanhTien";
            //
            // colTrangThai
            //
            this.colTrangThai.DataPropertyName = "TrangThaiThanhToan";
            this.colTrangThai.FillWeight = 26F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Name = "colTrangThai";
            //
            // pnlHoaDonTieuDe
            //
            this.pnlHoaDonTieuDe.BackColor = System.Drawing.Color.White;
            this.pnlHoaDonTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHoaDonTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlHoaDonTieuDe.Size = new System.Drawing.Size(439, 46);
            this.pnlHoaDonTieuDe.Controls.Add(this.lblTieuDeHoaDon);
            this.pnlHoaDonTieuDe.Controls.Add(this.btnLamMoiTrangChu);
            this.pnlHoaDonTieuDe.Name = "pnlHoaDonTieuDe";
            this.pnlHoaDonTieuDe.TabIndex = 1;
            //
            // lblTieuDeHoaDon
            //
            this.lblTieuDeHoaDon.AutoSize = true;
            this.lblTieuDeHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeHoaDon.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblTieuDeHoaDon.Location = new System.Drawing.Point(14, 12);
            this.lblTieuDeHoaDon.Size = new System.Drawing.Size(130, 21);
            this.lblTieuDeHoaDon.Text = "Hóa đơn gần đây";
            this.lblTieuDeHoaDon.Name = "lblTieuDeHoaDon";
            this.lblTieuDeHoaDon.TabIndex = 0;
            //
            // btnLamMoiTrangChu
            //
            this.btnLamMoiTrangChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiTrangChu.BackColor = System.Drawing.Color.FromArgb(184, 87, 26);
            this.btnLamMoiTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiTrangChu.FlatAppearance.BorderSize = 0;
            this.btnLamMoiTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiTrangChu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoiTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiTrangChu.Location = new System.Drawing.Point(329, 8);
            this.btnLamMoiTrangChu.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoiTrangChu.Text = "Làm mới";
            this.btnLamMoiTrangChu.UseVisualStyleBackColor = false;
            this.btnLamMoiTrangChu.Name = "btnLamMoiTrangChu";
            this.btnLamMoiTrangChu.TabIndex = 1;
            this.btnLamMoiTrangChu.Click += new System.EventHandler(this.btnLamMoiTrangChu_Click);
            //
            // tmrDongHo
            //
            this.tmrDongHo.Enabled = true;
            this.tmrDongHo.Interval = 1000;
            this.tmrDongHo.Tick += new System.EventHandler(this.tmrDongHo_Tick);
            //
            // FormTrangChu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 239, 230);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlBanner);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Shop Quần Áo";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.pnlHoaDonTieuDe.ResumeLayout(false);
            this.pnlHoaDonGanDay.ResumeLayout(false);
            this.pnlBieuDoTieuDe.ResumeLayout(false);
            this.pnlBieuDo.ResumeLayout(false);
            this.tlpDuoi.ResumeLayout(false);
            this.flpThaoTacNhanh.ResumeLayout(false);
            this.pnlThaoTacNhanh.ResumeLayout(false);
            this.pnlVachDoanhThu.ResumeLayout(false);
            this.pnlTheDoanhThu.ResumeLayout(false);
            this.pnlVachHoaDon.ResumeLayout(false);
            this.pnlTheHoaDon.ResumeLayout(false);
            this.pnlVachKhachHang.ResumeLayout(false);
            this.pnlTheKhachHang.ResumeLayout(false);
            this.pnlVachSanPham.ResumeLayout(false);
            this.pnlTheSanPham.ResumeLayout(false);
            this.tlpThe.ResumeLayout(false);
            this.tlpTrangChu.ResumeLayout(false);
            this.pnlTrangChu.ResumeLayout(false);
            this.pnlNoiDung.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonGanDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các control (tên dùng trong file FormTrangChu.cs)
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTenPhanMem;
        private System.Windows.Forms.Label lblKhauHieu;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslNgayGio;
        private System.Windows.Forms.ToolStripStatusLabel tslKhoangTrong;
        private System.Windows.Forms.ToolStripStatusLabel tslTrangThaiKetNoi;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnMenuTrangChu;
        private System.Windows.Forms.Button btnMenuSanPham;
        private System.Windows.Forms.Button btnMenuDanhMuc;
        private System.Windows.Forms.Button btnMenuThuongHieu;
        private System.Windows.Forms.Button btnMenuKhachHang;
        private System.Windows.Forms.Button btnMenuNhanVien;
        private System.Windows.Forms.Button btnMenuNhaCungCap;
        private System.Windows.Forms.Button btnMenuBanHang;
        private System.Windows.Forms.Button btnMenuHoaDon;
        private System.Windows.Forms.Button btnMenuPhieuNhap;
        private System.Windows.Forms.Button btnMenuThongKe;
        private System.Windows.Forms.Button btnMenuTaiKhoan;
        private System.Windows.Forms.Button btnMenuDangXuat;
        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.Panel pnlTrangChu;
        private System.Windows.Forms.TableLayoutPanel tlpTrangChu;
        private System.Windows.Forms.Button btnCanhBaoTonKho;
        private System.Windows.Forms.TableLayoutPanel tlpThe;
        private System.Windows.Forms.Panel pnlTheSanPham;
        private System.Windows.Forms.Label lblTieuDeTheSanPham;
        private System.Windows.Forms.Label lblSoSanPham;
        private System.Windows.Forms.Panel pnlVachSanPham;
        private System.Windows.Forms.Panel pnlTheKhachHang;
        private System.Windows.Forms.Label lblTieuDeTheKhachHang;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.Panel pnlVachKhachHang;
        private System.Windows.Forms.Panel pnlTheHoaDon;
        private System.Windows.Forms.Label lblTieuDeTheHoaDon;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Panel pnlVachHoaDon;
        private System.Windows.Forms.Panel pnlTheDoanhThu;
        private System.Windows.Forms.Label lblTieuDeTheDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Panel pnlVachDoanhThu;
        private System.Windows.Forms.Panel pnlThaoTacNhanh;
        private System.Windows.Forms.FlowLayoutPanel flpThaoTacNhanh;
        private System.Windows.Forms.Label lblTieuDeThaoTac;
        private System.Windows.Forms.Button btnNhanhBanHang;
        private System.Windows.Forms.Button btnNhanhPhieuNhap;
        private System.Windows.Forms.Button btnNhanhSanPham;
        private System.Windows.Forms.Button btnNhanhKhachHang;
        private System.Windows.Forms.Button btnNhanhHoaDon;
        private System.Windows.Forms.Button btnNhanhThongKe;
        private System.Windows.Forms.Button btnNhanhNhanVien;
        private System.Windows.Forms.Button btnNhanhTaiKhoan;
        private System.Windows.Forms.TableLayoutPanel tlpDuoi;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Panel pnlBieuDoTieuDe;
        private System.Windows.Forms.Label lblTieuDeBieuDo;
        private System.Windows.Forms.ComboBox cboKhoangBieuDo;
        private System.Windows.Forms.Panel pnlHoaDonGanDay;
        private System.Windows.Forms.DataGridView dgvHoaDonGanDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlHoaDonTieuDe;
        private System.Windows.Forms.Label lblTieuDeHoaDon;
        private System.Windows.Forms.Button btnLamMoiTrangChu;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}