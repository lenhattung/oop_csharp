namespace Lab11._Inheritance_2
{
    public class NhanVien
    {
        // field private
        private string _ten;
        private string _diaChi;
        private decimal _luongCoBan;

        // property (getter/setter)
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public decimal LuongCoBan
        {
            get { return _luongCoBan; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Lương không hợp lệ!");
                else
                    _luongCoBan = value;
            }
        }

        // constructor
        public NhanVien(string ten, string diaChi, decimal luongCoBan)
        {
            Ten = ten;
            DiaChi = diaChi;
            LuongCoBan = luongCoBan;
        }

        public void HienThi()
        {
            Console.WriteLine($"Tên: {Ten}, Địa chỉ: {DiaChi}, Lương: {LuongCoBan:N0}đ");
        }

        // virtual: cho phép lớp con ghi đè
        public virtual decimal TinhLuong()
        {
            return LuongCoBan;
        }
    }
}
