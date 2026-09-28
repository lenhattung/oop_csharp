namespace Lab15_BaiKiemTra3
{
    public class QuanLyNhanVien
    {
        private List<NhanVien> dsNV = new List<NhanVien>();

        public bool Them(NhanVien nv)
        {
            foreach (NhanVien x in dsNV)
                if (x.MaNV == nv.MaNV) return false;   // trùng mã -> không thêm
            dsNV.Add(nv);
            return true;
        }

        public double TongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in dsNV) tong += nv.TinhLuong();
            return tong;
        }

        public NhanVien TimLuongCaoNhat()
        {
            if (dsNV.Count == 0) return null;
            NhanVien max = dsNV[0];
            foreach (NhanVien nv in dsNV)
                if (nv.TinhLuong() > max.TinhLuong()) max = nv;
            return max;
        }

        public void SapXepGiamDanTheoLuong()
        {
            dsNV.Sort((a, b) => b.TinhLuong().CompareTo(a.TinhLuong()));
        }

        public List<NhanVien> LayDanhSachSanXuat()
        {
            List<NhanVien> kq = new List<NhanVien>();
            foreach (NhanVien nv in dsNV)
                if (nv is NhanVienSanXuat) kq.Add(nv);
            return kq;
        }

        public void InDanhSach()
        {
            foreach (NhanVien nv in dsNV) Console.WriteLine(nv);
        }
    }
}
