namespace Lab10._Inheritance
{
    internal class GiamDoc : NhanVien   // sub class, lớp con
    {
        public decimal TyLeThuong;      // ← riêng của GiamDoc

        public void HienThi()           // ← trùng lần thứ 3
        {
            Console.WriteLine($"Tên: {Ten}, Địa chỉ: {DiaChi}, Lương: {LuongCoBan:N0}đ");
        }

        public decimal TinhLuong()
        {
            return LuongCoBan + LuongCoBan * TyLeThuong / 100;
        }
    }
}
