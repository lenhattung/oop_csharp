namespace Lab13._Abstract_Class
{
    public class HinhTron : HinhHoc
    {
        public double BanKinh { get; set; }

        public HinhTron(double banKinh) : base("Hình tròn")
        {
            BanKinh = banKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }


        public override string ToString()
        {
            return $"{TenHinh} (R = {BanKinh}): Diện tích = {TinhDienTich():F2}, Chu vi = {TinhChuVi():F2}";
        }
    }
}
