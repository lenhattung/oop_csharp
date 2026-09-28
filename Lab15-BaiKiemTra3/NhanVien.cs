namespace Lab15_BaiKiemTra3
{
    public abstract class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double luongCoBan;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = string.IsNullOrWhiteSpace(value) ? "Chưa có tên" : value.Trim(); }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value < 0 ? 0 : value; }
        }

        public NhanVien(string maNV, string hoTen, double luongCoBan)
        {
            MaNV = maNV;              // gán qua property để áp dụng kiểm tra
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
        }

        public abstract double TinhLuong();

        // CÂU 2: ToString gọi TinhLuong() -> tự động chạy đúng phiên bản của lớp con
        public override string ToString()
        {
            return $"{MaNV} | {HoTen} | Luong: {TinhLuong():N0}";
        }
    }
}
