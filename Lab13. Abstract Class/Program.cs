using Lab13._Abstract_Class;

//HinhHoc h = new HinhHoc(); // Khong the khai bao
HinhHoc h = new HinhChuNhat(5, 5);
HinhChuNhat h2 = new HinhChuNhat(5, 5);

HinhHoc[] danhSachHinh = new HinhHoc[]
       {
            new HinhTron(5),
            new HinhChuNhat(4, 6),
            new HinhTamGiac(3, 4, 5),
            new HinhTron(2),
            new HinhChuNhat(10, 2)
       };


Console.WriteLine("Danh sách hình học:");
Console.WriteLine("--------------------------------------------------");
foreach (HinhHoc hinh in danhSachHinh)
{
    // ToString() được override ở từng lớp con, tự động gọi đúng phiên bản
    Console.WriteLine(hinh.ToString());
}