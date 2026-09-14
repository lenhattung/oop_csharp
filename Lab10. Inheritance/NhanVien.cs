namespace Lab10._Inheritance
{
    // Quy tắc: phần nào giống nhau ở mọi class → đưa lên lớp cha.Phần nào chỉ riêng 1 class có → giữ lại ở lớp con.
    public class NhanVien // <- base class , lớp cha, chứa phần trùng lặp
    {
        public string Ten;
        public string DiaChi;
        public decimal LuongCoBan;

        public void HienThi()
        {
            Console.WriteLine($"Tên: {Ten}, Địa chỉ: {DiaChi}, Lương: {LuongCoBan:N0}đ");
        }

        public decimal TinhLuong()
        {
            return LuongCoBan;
        }
    }
}
