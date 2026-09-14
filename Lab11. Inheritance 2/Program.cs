/*
 class LopCha
{
    // thành viên dùng chung
}

class LopCon : LopCha   // dấu hai chấm = kế thừa
{
    // chỉ viết thêm thành viên riêng
}
 */

using Lab11._Inheritance_2;

NhanVien nv = new NhanVien("An", "Q1", 8000000);
QuanLy ql = new QuanLy("Bình", "Q3", 15000000, 3000000);
GiamDoc gd = new GiamDoc("Chi", "Q7", 30000000, 5000000, 20);

nv.HienThi();   // dùng thẳng của NhanVien
ql.HienThi();   // kế thừa, không viết lại
gd.HienThi();   // kế thừa qua 2 cấp

Console.WriteLine($"Lương An: {nv.TinhLuong():N0}đ");   // 8,000,000đ
Console.WriteLine($"Lương Bình: {ql.TinhLuong():N0}đ"); // 18,000,000đ
Console.WriteLine($"Lương Chi: {gd.TinhLuong():N0}đ");  // 42,000,000đ

NhanVien nv2 = new QuanLy("Bình", "Q3", 15000000, 3000000);

NhanVien nv3 = new GiamDoc("Chi", "Q7", 30000000, 5000000, 20);

// QuanLy ql2 = new NhanVien("An", "Q1", 8000000);