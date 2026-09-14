namespace Lab10._Inheritance
{
    internal class QuanLy : NhanVien     // sub class, lớp con
    {
        public decimal PhuCapQuanLy;    // ← riêng của QuanLy

        public void HienThi()           // ← trùng với NhanVien
        {
            Console.WriteLine($"Tên: {Ten}, Địa chỉ: {DiaChi}, Lương: {LuongCoBan:N0}đ");
        }

        public decimal TinhLuong()      // ← gần giống NhanVien, chỉ khác công thức
        {
            return LuongCoBan + PhuCapQuanLy;
        }
    }
}
