namespace Lab13._Interface
{
    public class DienThoai : ThietBiDienTu, IKetNoiWifi, IGoiDien
    {

        // Thuộc tính riêng của điện thoại — không có ở TiVi hay các thiết bị khác
        public string SoDienThoai { get; set; }
        public int DungLuongPin { get; set; }      // đơn vị: mAh
        public bool CoHoTro5G { get; set; }

        private bool dangKetNoi = false;
        private string mangHienTai = string.Empty;
        private bool dangTrongCuocGoi = false;


        public DienThoai(string tenThietBi, string nhanHieu, string heDieuHanh,
                           string soDienThoai, int dungLuongPin, bool coHoTro5G)
             : base(tenThietBi, nhanHieu, heDieuHanh)
        {
            SoDienThoai = soDienThoai;
            DungLuongPin = dungLuongPin;
            CoHoTro5G = coHoTro5G;
        }

        public void KetNoi(string tenMang)
        {
            dangKetNoi = true;
            mangHienTai = tenMang;
            Console.WriteLine($"[{TenThietBi}] Đã kết nối vào mạng \"{tenMang}\"");

        }

        public void NgatKetNoi()
        {

            if (dangKetNoi)
            {
                Console.WriteLine($"[{TenThietBi}] Đã ngắt kết nối khỏi \"{mangHienTai}\"");
                dangKetNoi = false;
                mangHienTai = string.Empty;
            }
            else
            {
                Console.WriteLine($"[{TenThietBi}] Hiện không kết nối mạng nào");
            }
        }

        // Override để hiển thị thêm thông tin riêng của điện thoại
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            string trangThai = dangKetNoi ? $"Đang kết nối \"{mangHienTai}\"" : "Chưa kết nối";
            Console.WriteLine($"  SĐT: {SoDienThoai} | Pin: {DungLuongPin}mAh | 5G: {(CoHoTro5G ? "Có" : "Không")}");
            Console.WriteLine($"  Wifi: {trangThai}");
        }

        // Hiện thực IGoiDien — TiVi không có khả năng này
        public void GoiDien(string soDienThoai)
        {
            dangTrongCuocGoi = true;
            Console.WriteLine($"[{TenThietBi}] Đang gọi tới số {soDienThoai}...");
        }

        public void NhanCuocGoi(string soGoiDen)
        {
            dangTrongCuocGoi = true;
            Console.WriteLine($"[{TenThietBi}] Cuộc gọi đến từ {soGoiDen} — đã trả lời");
        }

        public void KetThucCuocGoi()
        {
            if (dangTrongCuocGoi)
            {
                Console.WriteLine($"[{TenThietBi}] Đã kết thúc cuộc gọi");
                dangTrongCuocGoi = false;
            }
        }

    }
}
