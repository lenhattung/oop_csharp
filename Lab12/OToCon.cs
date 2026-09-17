namespace Lab12
{
    public class OToCon : PhuongTien
    {
        public int SoChoNgoi { get; set; }
        private const double TY_LE_CHIET_KHAU = 0.15; // giảm 15%

        public OToCon(string bienSo, string tenChuXe, double giaThueMoiGio, int soChoNgoi)
            : base(bienSo, tenChuXe, giaThueMoiGio)
        {
            SoChoNgoi = soChoNgoi;
        }

        public override double TinhPhiThue(int soGio)
        {
            double phi = base.TinhPhiThue(soGio);
            if (soGio >= 72) // thuê từ 3 ngày (72 giờ) trở lên
            {
                phi -= phi * TY_LE_CHIET_KHAU;
            }
            return phi;
        }

        public override void InThongTinThue(int soGio)
        {
            Console.WriteLine("--- Ô TÔ CON THỜI ---");
            base.InThongTinThue(soGio);
            Console.WriteLine($"Số chỗ ngồi: {SoChoNgoi}");
            if (soGio >= 72)
                Console.WriteLine("(Đã áp dụng chiết khấu thuê dài ngày)");
        }
    }
}
