namespace Lab15_BaiKiemTra3
{
    public class NhanVienVanPhong : NhanVien
    {
        private int soNgayCong;
        public int SoNgayCong
        {
            get { return soNgayCong; }
            set { soNgayCong = (value < 0 || value > 31) ? 0 : value; }
        }

        public NhanVienVanPhong(string maNV, string hoTen, double luongCoBan, int soNgayCong)
            : base(maNV, hoTen, luongCoBan)
        {
            SoNgayCong = soNgayCong;
        }

        public override double TinhLuong()
        {
            return LuongCoBan + SoNgayCong * 200000;
        }

        public override string ToString()
        {
            return $"[VP] {base.ToString()} | Ngay cong: {SoNgayCong}";
        }
    }
}
