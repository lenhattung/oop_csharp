namespace Lab13._Abstract_Class
{
    internal class HinhTamGiac : HinhHoc
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }
        public double CanhC { get; set; }

        public HinhTamGiac(double a, double b, double c) : base("Hình tam giác")
        {
            // Kiểm tra điều kiện 3 cạnh hợp lệ (bất đẳng thức tam giác)
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Ba cạnh không tạo thành tam giác hợp lệ.");

            CanhA = a;
            CanhB = b;
            CanhC = c;
        }

        public override double TinhChuVi()
        {
            return CanhA + CanhB + CanhC;
        }

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2; // nửa chu vi
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC)); // công thức Heron
        }

        public override string ToString()
        {
            return $"{TenHinh} ({CanhA}, {CanhB}, {CanhC}): Diện tích = {TinhDienTich():F2}, Chu vi = {TinhChuVi():F2}";
        }

    }
}
