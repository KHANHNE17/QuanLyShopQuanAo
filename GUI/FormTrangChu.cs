using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyShopQuanAo.BUS;

namespace QuanLyShopQuanAo.GUI
{
    /// <summary>
    /// Form chính (dashboard): banner, menu bên trái, vùng nội dung, thanh trạng thái.
    /// - Mục "Trang chủ" hiển thị các thẻ thống kê, biểu đồ doanh thu và hóa đơn gần đây.
    /// - Các mục khác mở form chức năng tương ứng (FormSanPham, FormKhachHang, ...) nhúng vào vùng nội dung.
    /// Giao diện nằm trong FormTrangChu.Designer.cs, file này chỉ xử lý logic.
    /// </summary>
    public partial class FormTrangChu : Form
    {
        // Các đối tượng BUS
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private readonly SanPhamBUS sanPhamBUS = new SanPhamBUS();
        private readonly KhachHangBUS khachHangBUS = new KhachHangBUS();
        private readonly TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        // Định dạng số theo kiểu Việt Nam: 1.234.567
        private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

        // Màu của nút menu: bình thường và đang chọn
        private readonly Color mauMenuThuong = Color.FromArgb(78, 52, 46);
        private readonly Color mauMenuDangChon = Color.FromArgb(184, 87, 26);

        // Form chức năng đang được nhúng trong vùng nội dung (null nếu đang ở Trang chủ)
        private Form formDangMo;

        // Cờ để bỏ qua sự kiện của combobox khi đang khởi tạo
        private bool dangKhoiTao;

        /// <summary>true nếu người dùng bấm Đăng xuất (Program.cs sẽ mở lại form đăng nhập); false nếu đóng cửa sổ để thoát.</summary>
        public bool DaDangXuat { get; private set; }

        public FormTrangChu()
        {
            InitializeComponent();
            // Visual Studio Designer không lưu thuộc tính AutoGenerateColumns, nên phải đặt ở đây:
            // nếu để mặc định (true) thì lưới sẽ tự sinh cột theo mọi thuộc tính của DTO và mất cột đã thiết kế.
            dgvHoaDonGanDay.AutoGenerateColumns = false;
        }

        /* ===================== KHỞI TẠO ===================== */

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            HienThongTinNguoiDung();
            PhanQuyenMenu();
            CapNhatDongHo();

            dangKhoiTao = true;
            cboKhoangBieuDo.SelectedIndex = 0;   // mặc định xem 7 ngày gần nhất
            dangKhoiTao = false;

            HienTrangChu();
        }

        // Hiện tên nhân viên và vai trò ở banner
        private void HienThongTinNguoiDung()
        {
            string tenNhanVien = PhienLamViec.NhanVien != null ? PhienLamViec.NhanVien.HoTen : "bạn";
            string tenDangNhap = PhienLamViec.TaiKhoan != null ? PhienLamViec.TaiKhoan.TenDangNhap : "";
            string vaiTro = PhienLamViec.LaQuanTri ? "Quản trị viên" : "Nhân viên bán hàng";

            lblXinChao.Text = "Xin chào, " + tenNhanVien;
            lblVaiTro.Text = vaiTro + (tenDangNhap.Length > 0 ? "  •  " + tenDangNhap : "");
        }

        // Phân quyền: nhân viên bán hàng chỉ thấy các mục phục vụ bán hàng
        private void PhanQuyenMenu()
        {
            bool laQuanTri = PhienLamViec.LaQuanTri;

            btnMenuDanhMuc.Visible = laQuanTri;
            btnMenuThuongHieu.Visible = laQuanTri;
            btnMenuNhanVien.Visible = laQuanTri;
            btnMenuNhaCungCap.Visible = laQuanTri;
            btnMenuPhieuNhap.Visible = laQuanTri;
            btnMenuThongKe.Visible = laQuanTri;

            // Các nút thao tác nhanh ở trang chủ cũng ẩn theo cùng quy tắc
            btnNhanhPhieuNhap.Visible = laQuanTri;
            btnNhanhThongKe.Visible = laQuanTri;
            btnNhanhNhanVien.Visible = laQuanTri;
        }

        /* ===================== ĐIỀU HƯỚNG MENU ===================== */

        // Dùng chung cho các nút menu: Tag của nút chứa tên chức năng (vd "SanPham" -> FormSanPham)
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;
            string tenChucNang = Convert.ToString(nut.Tag);

            if (tenChucNang == "TrangChu")
                HienTrangChu();
            else
                MoFormCon(tenChucNang, nut);
        }

        // Nút thao tác nhanh ở trang chủ: mở cùng chức năng với nút menu có cùng Tag
        // (bấm giả lập nút menu để menu cũng được tô sáng đúng mục)
        private void btnNhanh_Click(object sender, EventArgs e)
        {
            Button nutNhanh = (Button)sender;
            string tenChucNang = Convert.ToString(nutNhanh.Tag);

            foreach (Control control in flpMenu.Controls)
            {
                Button nutMenu = control as Button;
                if (nutMenu != null && Convert.ToString(nutMenu.Tag) == tenChucNang)
                {
                    nutMenu.PerformClick();
                    return;
                }
            }
        }

        private void btnMenuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            tmrDongHo.Stop();
            taiKhoanBUS.DangXuat();
            DaDangXuat = true;
            Close();
        }

        // Quay về màn hình Trang chủ (đóng form chức năng đang mở và tải lại số liệu)
        private void HienTrangChu()
        {
            DongFormCon();
            pnlTrangChu.Visible = true;
            pnlTrangChu.BringToFront();
            ChonMenu(btnMenuTrangChu);
            TaiTrangChu();
        }

        // Mở form chức năng "Form" + tenChucNang và nhúng vào vùng nội dung.
        // Dùng Type.GetType để tạo form theo tên; nếu form chưa có thì báo cho người dùng.
        private void MoFormCon(string tenChucNang, Button nut)
        {
            Type loaiForm = Type.GetType("QuanLyShopQuanAo.GUI.Form" + tenChucNang);
            if (loaiForm == null)
            {
                MessageBox.Show("Chức năng \"" + nut.Text.Trim() + "\" chưa được cài đặt (thiếu Form" + tenChucNang + ").",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Đang mở đúng form này rồi thì không mở lại
            if (formDangMo != null && formDangMo.GetType() == loaiForm)
            {
                ChonMenu(nut);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                DongFormCon();

                Form formCon = (Form)Activator.CreateInstance(loaiForm);
                formCon.TopLevel = false;
                formCon.FormBorderStyle = FormBorderStyle.None;
                formCon.Dock = DockStyle.Fill;

                pnlNoiDung.Controls.Add(formCon);
                pnlTrangChu.Visible = false;
                formCon.Show();
                formCon.BringToFront();

                formDangMo = formCon;
                ChonMenu(nut);
            }
            catch (Exception ex)
            {
                Exception loi = ex.InnerException != null ? ex.InnerException : ex;
                MessageBox.Show("Không mở được chức năng \"" + nut.Text.Trim() + "\".\n" + loi.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienTrangChu();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // Đóng form chức năng đang nhúng (nếu có)
        private void DongFormCon()
        {
            if (formDangMo != null)
            {
                formDangMo.Close();
                formDangMo = null;
            }
        }

        // Tô màu nút menu đang chọn, các nút khác về màu thường
        private void ChonMenu(Button nutDangChon)
        {
            foreach (Control control in flpMenu.Controls)
            {
                Button nut = control as Button;
                if (nut == null) continue;
                nut.BackColor = (nut == nutDangChon) ? mauMenuDangChon : mauMenuThuong;
            }
        }

        /* ===================== DỮ LIỆU TRANG CHỦ ===================== */

        // Dòng cảnh báo: đếm sản phẩm đang kinh doanh có tồn kho thấp (từ ngưỡng trở xuống)
        private void TaiCanhBaoTonKho()
        {
            var sapHet = sanPhamBUS.LayTonKhoThap().Where(x => x.TrangThai).ToList();
            int soHet = sapHet.Count(x => x.SoLuongTon <= 0);

            if (sapHet.Count == 0)
            {
                btnCanhBaoTonKho.Text = "✔  Tất cả sản phẩm đang kinh doanh còn đủ hàng";
                btnCanhBaoTonKho.BackColor = Color.FromArgb(232, 245, 233);
                btnCanhBaoTonKho.ForeColor = Color.FromArgb(46, 125, 50);
                btnCanhBaoTonKho.FlatAppearance.BorderColor = Color.FromArgb(165, 214, 167);
            }
            else
            {
                btnCanhBaoTonKho.Text = "⚠  " + sapHet.Count + " sản phẩm sắp hết hàng"
                                        + (soHet > 0 ? " (trong đó " + soHet + " đã hết)" : "")
                                        + "  -  bấm để xem danh sách";
                btnCanhBaoTonKho.BackColor = Color.FromArgb(255, 243, 224);
                btnCanhBaoTonKho.ForeColor = Color.FromArgb(230, 81, 0);
                btnCanhBaoTonKho.FlatAppearance.BorderColor = Color.FromArgb(255, 183, 77);
            }
        }

        // Bấm dòng cảnh báo: mở danh sách; nếu chọn "Nhập hàng" thì chuyển sang form phiếu nhập
        private void btnCanhBaoTonKho_Click(object sender, EventArgs e)
        {
            using (FormCanhBaoTonKho formCanhBao = new FormCanhBaoTonKho())
            {
                formCanhBao.ShowDialog(this);
                if (formCanhBao.MoPhieuNhap) btnMenuPhieuNhap.PerformClick();
            }
        }

        private void btnLamMoiTrangChu_Click(object sender, EventArgs e)
        {
            TaiTrangChu();
        }

        // Tải 4 thẻ thống kê, danh sách hóa đơn gần đây và biểu đồ
        private void TaiTrangChu()
        {
            try
            {
                lblSoSanPham.Text = sanPhamBUS.DemTatCa().ToString("N0", viVN);
                lblSoKhachHang.Text = khachHangBUS.DemTatCa().ToString("N0", viVN);
                lblSoHoaDon.Text = hoaDonBUS.DemTatCa().ToString("N0", viVN);
                lblDoanhThu.Text = hoaDonBUS.TongDoanhThuTatCa().ToString("N0", viVN) + " đ";

                dgvHoaDonGanDay.DataSource = hoaDonBUS.LayGanDay(10);
                TaiCanhBaoTonKho();
                TaiBieuDo();
                DatTrangThaiKetNoi(true);
            }
            catch (Exception ex)
            {
                DatTrangThaiKetNoi(false);
                MessageBox.Show("Không tải được dữ liệu trang chủ.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboKhoangBieuDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangKhoiTao) return;

            try
            {
                TaiBieuDo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được biểu đồ.\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Vẽ biểu đồ cột doanh thu theo lựa chọn: 7 ngày, 30 ngày hoặc 12 tháng gần nhất.
        // Những ngày/tháng không có hóa đơn vẫn được vẽ với giá trị 0.
        private void TaiBieuDo()
        {
            System.Windows.Forms.DataVisualization.Charting.Series chuoi = chartDoanhThu.Series["DoanhThu"];
            chuoi.Points.Clear();
            DateTime homNay = DateTime.Today;

            if (cboKhoangBieuDo.SelectedIndex == 2)
            {
                // 12 tháng gần nhất (tính từ đầu tháng của 11 tháng trước)
                DateTime dauThangDau = new DateTime(homNay.Year, homNay.Month, 1).AddMonths(-11);
                DataTable bangThang = hoaDonBUS.DoanhThuTheoThang(dauThangDau, homNay);

                Dictionary<int, decimal> theoThang = bangThang.Rows.Cast<DataRow>().ToDictionary(
                    dong => Convert.ToInt32(dong["Nam"]) * 100 + Convert.ToInt32(dong["Thang"]),
                    dong => Convert.ToDecimal(dong["DoanhThu"]));

                for (int i = 0; i < 12; i++)
                {
                    DateTime thang = dauThangDau.AddMonths(i);
                    decimal doanhThu;
                    theoThang.TryGetValue(thang.Year * 100 + thang.Month, out doanhThu);
                    chuoi.Points.AddXY(thang.ToString("MM/yyyy", viVN), (double)doanhThu);
                }
            }
            else
            {
                // 7 hoặc 30 ngày gần nhất
                int soNgay = cboKhoangBieuDo.SelectedIndex == 1 ? 30 : 7;
                DateTime tuNgay = homNay.AddDays(-(soNgay - 1));
                DataTable bangNgay = hoaDonBUS.DoanhThuTheoNgay(tuNgay, homNay);

                Dictionary<DateTime, decimal> theoNgay = bangNgay.Rows.Cast<DataRow>().ToDictionary(
                    dong => Convert.ToDateTime(dong["Ngay"]).Date,
                    dong => Convert.ToDecimal(dong["DoanhThu"]));

                for (int i = 0; i < soNgay; i++)
                {
                    DateTime ngay = tuNgay.AddDays(i);
                    decimal doanhThu;
                    theoNgay.TryGetValue(ngay, out doanhThu);
                    chuoi.Points.AddXY(ngay.ToString("dd/MM", viVN), (double)doanhThu);
                }
            }
        }

        // Tô màu cột "Trạng thái" của danh sách hóa đơn gần đây
        private void dgvHoaDonGanDay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colTrangThai.Index || e.Value == null) return;

            string trangThai = Convert.ToString(e.Value);
            if (trangThai == HoaDonBUS.TrangThaiDaThanhToan)
                e.CellStyle.ForeColor = Color.FromArgb(46, 125, 50);
            else if (trangThai == HoaDonBUS.TrangThaiChuaThanhToan)
                e.CellStyle.ForeColor = Color.FromArgb(230, 81, 0);
            else if (trangThai == HoaDonBUS.TrangThaiDaHuy)
                e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);
        }

        /* ===================== THANH TRẠNG THÁI ===================== */

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            CapNhatDongHo();
        }

        private void CapNhatDongHo()
        {
            DateTime bayGio = DateTime.Now;
            tslNgayGio.Text = "Ngày: " + bayGio.ToString("dd/MM/yyyy", viVN) + "   Giờ: " + bayGio.ToString("HH:mm:ss", viVN);
        }

        private void DatTrangThaiKetNoi(bool dangKetNoi)
        {
            tslTrangThaiKetNoi.Text = dangKetNoi ? "Kết nối: Online" : "Kết nối: Offline";
            tslTrangThaiKetNoi.ForeColor = dangKetNoi ? Color.FromArgb(165, 214, 167) : Color.FromArgb(239, 154, 154);
        }
    }
}