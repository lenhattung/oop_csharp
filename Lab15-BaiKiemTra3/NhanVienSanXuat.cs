namespace Lab15_BaiKiemTra3
{
    internal class NhanVienSanXuat : NhanVien
    {
        private double donGia;
        private List<int> dsSanLuong = new List<int>();

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value < 0 ? 0 : value; }
        }

        // Property chỉ đọc: tính từ danh sách, bên ngoài không sửa được
        public int TongSanPham
        {
            get
            {
                int tong = 0;
                foreach (int sl in dsSanLuong) tong += sl;
                return tong;
            }
        }

        public NhanVienSanXuat(string maNV, string hoTen, double luongCoBan, double donGia)
        : base(maNV, hoTen, luongCoBan)
        {
            DonGia = donGia;
        }

        public void ThemSanLuong(int sl)
        {
            if (sl >= 0) dsSanLuong.Add(sl);
        }

        public override double TinhLuong()
        {
            return LuongCoBan + TongSanPham * DonGia;
        }

        public override string ToString()
        {
            return $"[SX] {base.ToString()} | SP: {TongSanPham} x {DonGia:N0}";
        }
    }
}
