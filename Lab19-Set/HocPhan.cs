namespace Lab19_Set
{
    public class HocPhan
    {
        public string MaHP { get; }
        public string TenHP { get; }
        public int SiSoToiDa { get; }
        private readonly HashSet<string> _dsSV = new();

        public HocPhan(string maHP, string tenHP, int siSoToiDa)
        {
            MaHP = maHP;
            TenHP = tenHP;
            SiSoToiDa = siSoToiDa;
        }

        public int SiSo => _dsSV.Count;
        public IReadOnlySet<string> DanhSachSV => _dsSV;   // chỉ cho đọc

        public string DangKy(string maSV)
        {
            if (_dsSV.Contains(maSV)) return "Đã đăng ký trước đó";
            if (_dsSV.Count >= SiSoToiDa) return "Lớp đã đủ sĩ số";
            _dsSV.Add(maSV);
            return "Đăng ký thành công";
        }

        public bool HuyDangKy(string maSV) => _dsSV.Remove(maSV);
        public bool CoDangKy(string maSV) => _dsSV.Contains(maSV);

    }
}
