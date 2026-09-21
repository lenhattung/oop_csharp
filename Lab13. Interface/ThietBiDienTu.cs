namespace Lab13._Interface
{
    public abstract class ThietBiDienTu
    {
        public string TenThietBi { get; set; }
        public string NhanHieu { get; set; }
        public string HeDieuHanh { get; set; }

        protected ThietBiDienTu(string tenThietBi, string nhanHieu, string heDieuHanh)
        {
            TenThietBi = tenThietBi;
            NhanHieu = nhanHieu;
            HeDieuHanh = heDieuHanh;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"{TenThietBi} ({NhanHieu}) - HĐH: {HeDieuHanh}");
        }


    }
}
