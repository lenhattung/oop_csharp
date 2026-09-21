namespace Lab13._Interface
{
    internal class TiVi : ThietBiDienTu, IKetNoiWifi
    {
        // Thuộc tính riêng của TV
        public double KichThuocInch { get; set; }
        public bool HoTroSmartTV { get; set; }

        public TiVi(string tenThietBi, string nhanHieu, string heDieuHanh,
                     double kichThuocInch, bool hoTroSmartTV)
            : base(tenThietBi, nhanHieu, heDieuHanh)
        {
            KichThuocInch = kichThuocInch;
            HoTroSmartTV = hoTroSmartTV;
        }

        public void KetNoi(string tenMang)
        {
            Console.WriteLine($"[Smart TV {TenThietBi}] Đang kết nối tới \"{tenMang}\"...");
        }

        public void NgatKetNoi()
        {
            Console.WriteLine($"[Smart TV {TenThietBi}] Đã tắt Wifi");
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"  Kích thước: {KichThuocInch} inch | Smart TV: {(HoTroSmartTV ? "Có" : "Không")}");
        }
    }
}
