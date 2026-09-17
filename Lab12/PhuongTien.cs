namespace Lab12
{
    public class PhuongTien
    {
        public string BienSo { get; set; }
        public string TenChuXe { get; set; }
        public double GiaThueMoiGio { get; set; }

        public PhuongTien()
        {

        }
        public PhuongTien(string bienSo, string tenChuXe, double giaThueMoiGio)
        {
            BienSo = bienSo;
            TenChuXe = tenChuXe;
            GiaThueMoiGio = giaThueMoiGio;
        }

        // Phương thức ảo để lớp con override
        public virtual double TinhPhiThue(int soGio)
        {
            return soGio * GiaThueMoiGio;
        }

        // Phương thức ảo để lớp con override
        public virtual void InThongTinThue(int soGio)
        {
            Console.WriteLine($"Biển số: {BienSo} - Chủ xe: {TenChuXe}");
            Console.WriteLine($"Số giờ thuê: {soGio} - Phí thuê: {TinhPhiThue(soGio):N0} VNĐ");
        }

    }
}
