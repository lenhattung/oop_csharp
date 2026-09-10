// static
/*
Thông thường, khi ta tạo một lớp và khai báo các biến, phương thức — những thành phần đó thuộc về đối tượng. Nghĩa là:
Phải tạo đối tượng mới dùng được
Mỗi đối tượng có bản sao riêng của biến đó → thay đổi ở một đối tượng không ảnh hưởng đến đối tượng khác
Khi dùng từ khóa static → thành phần đó KHÔNG thuộc về đối tượng, mà thuộc về LỚP.
 */
// Gọi trực tiếp, KHÔNG cần new PhepToan()
using Lab_09._Static;

double kq = PhepTinh.BinhPhuong(5);
Console.WriteLine($"5^2 = {kq}");


double chuVi = PhepTinh.TinhChuViHinhTron(4);
Console.WriteLine($"Chu vi = {chuVi}");