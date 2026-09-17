namespace Lab12
{
    public class XeMay : PhuongTien
    {
        public string LoaiXe { get; set; } // "Xe số" hoặc "Xe tay ga"
        private const double PHU_PHI_QUA_DEM = 20000;

        public XeMay()
        {

        }

        public XeMay(string bienSo, string tenChuXe, double giaThueMoiGio, string loaiXe)
      : base(bienSo, tenChuXe, giaThueMoiGio)
        {
            LoaiXe = loaiXe;
        }
        public override double TinhPhiThue(int soGio)
        {
            double phi = base.TinhPhiThue(soGio); // gọi lại công thức gốc của lớp cha
            if (soGio > 24)
            {
                phi += PHU_PHI_QUA_DEM;
            }
            return phi;
        }

        public override void InThongTinThue(int soGio)
        {
            Console.WriteLine("--- XE MÁY ---");
            base.InThongTinThue(soGio); // in phần thông tin chung
            Console.WriteLine($"Loại xe: {LoaiXe}");
            if (soGio > 24)
                Console.WriteLine("(Đã áp dụng phụ phí gửi qua đêm)");
        }

    }
}
