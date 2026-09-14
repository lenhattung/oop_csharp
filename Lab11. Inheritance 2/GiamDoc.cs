namespace Lab11._Inheritance_2
{
    internal class GiamDoc : QuanLy
    {
        private decimal _tyLeThuong;

        public decimal TyLeThuong
        {
            get { return _tyLeThuong; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Tỷ lệ thưởng không hợp lệ!");
                else
                    _tyLeThuong = value;
            }
        }

        // gọi thẳng lên constructor của QuanLy (QuanLy sẽ gọi tiếp base lên NhanVien)
        public GiamDoc(string ten, string diaChi, decimal luongCoBan, decimal phuCapQuanLy, decimal tyLeThuong)
            : base(ten, diaChi, luongCoBan, phuCapQuanLy)
        {
            TyLeThuong = tyLeThuong;
        }

        public override decimal TinhLuong()
        {
            // base.TinhLuong() = công thức của QuanLy: LuongCoBan + PhuCapQuanLy
            return base.TinhLuong() + base.TinhLuong() * TyLeThuong / 100;
        }
    }
}
