namespace Lab11._Inheritance_2
{
    public class QuanLy : NhanVien
    {
        // CHỈ khai báo phần RIÊNG — không lặp lại Ten/DiaChi/LuongCoBan
        private decimal _phuCapQuanLy;

        public decimal PhuCapQuanLy
        {
            get { return _phuCapQuanLy; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Phụ cấp không hợp lệ!");
                else
                    _phuCapQuanLy = value;
            }
        }

        // constructor gọi base(...) để tái sử dụng logic gán Ten/DiaChi/LuongCoBan
        public QuanLy(string ten, string diaChi, decimal luongCoBan, decimal phuCapQuanLy)
            : base(ten, diaChi, luongCoBan)
        {
            PhuCapQuanLy = phuCapQuanLy;
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + PhuCapQuanLy;
        }
    }
}
