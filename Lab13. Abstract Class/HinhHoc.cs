namespace Lab13._Abstract_Class
{
    public abstract class HinhHoc
    {

        public string TenHinh { get; set; }

        public HinhHoc(string tenHinh)
        {
            TenHinh = tenHinh;
        }

        // Phương thức trừu tượng - bắt buộc lớp con phải override
        public abstract double TinhDienTich();
        public abstract double TinhChuVi();
    }
}
