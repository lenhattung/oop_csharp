// Khởi tạo các đối tượng thiết bị
using Lab13._Interface;

DienThoai dienThoai = new DienThoai(
    "iPhone 15", "Apple", "iOS 17",
    "0901234567", 3349, true);

TiVi tiVi = new TiVi(
    "Smart TV Samsung", "Samsung", "Tizen OS",
    55, true);

Console.WriteLine("========== 1. HIỂN THỊ THÔNG TIN THIẾT BỊ (đa hình qua ThietBiDienTu) ==========\n");

List<ThietBiDienTu> dsThietBi = new List<ThietBiDienTu> { dienThoai, tiVi };
foreach (ThietBiDienTu tb in dsThietBi)
{
    tb.HienThiThongTin();
    Console.WriteLine();
}

Console.WriteLine("========== 2. KẾT NỐI WIFI (đa hình qua IKetNoiWifi — cả 2 thiết bị đều làm được) ==========\n");

List<IKetNoiWifi> dsWifi = new List<IKetNoiWifi> { dienThoai, tiVi };
foreach (IKetNoiWifi tb in dsWifi)
{
    tb.KetNoi("Home_Wifi_5G");
}

Console.WriteLine();
foreach (IKetNoiWifi tb in dsWifi)
{
    tb.NgatKetNoi();
}

Console.WriteLine("\n========== 3. GỌI ĐIỆN (chỉ DienThoai hiện thực IGoiDien — TiVi không thể) ==========\n");

// TiVi KHÔNG hiện thực IGoiDien nên không thể đưa vào danh sách này.
// Dòng dưới đây nếu bỏ comment sẽ báo lỗi biên dịch:
// List<IGoiDien> dsGoiDienLoi = new List<IGoiDien> { tiVi };

List<IGoiDien> dsGoiDien = new List<IGoiDien> { dienThoai };
foreach (IGoiDien thietBi in dsGoiDien)
{
    thietBi.GoiDien("0987654321");
    thietBi.NhanCuocGoi("0912345678");
    thietBi.KetThucCuocGoi();
}

Console.WriteLine("\n========== KẾT THÚC CHƯƠNG TRÌNH ==========");
Console.ReadKey();