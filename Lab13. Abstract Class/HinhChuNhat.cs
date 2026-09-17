namespace Lab13._Abstract_Class
{
    public class HinhChuNhat : HinhHoc
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public HinhChuNhat(double chieuDai, double chieuRong) : base("Hình chữ nhật")
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        public override string ToString()
        {
            return $"{TenHinh} ({ChieuDai} x {ChieuRong}): Diện tích = {TinhDienTich():F2}, Chu vi = {TinhChuVi():F2}";
        }
    }
}
