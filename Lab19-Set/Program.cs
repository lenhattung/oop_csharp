// SET : HashSet ; TreeSet
// Giống List, nhưng dữ liệu không được trùng lặp.
// MSSV, CCCD, Biển số xe
//HashSet<int> a = new HashSet<int>();
//a.Add(1);
//a.Add(2);
//a.Add(2);
//a.Add(2);
//a.Add(2);
//a.Add(4);
//Console.WriteLine("Count: " + a.Count);

using Lab19_Set;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var oop = new HocPhan("PM70205", "Lập trình hướng đối tượng", 4);
var ctdl = new HocPhan("PM70301", "Cấu trúc dữ liệu", 10);
string[] ds = { "SV01", "SV02", "SV03", "SV04", "SV05" };
foreach (var sv in ds)
{
    oop.DangKy(sv);
}


string[] ds2 = { "SV02", "SV04", "SV06", "SV07" };
foreach (var sv in ds2)
{
    ctdl.DangKy(sv);
}

Console.WriteLine("\n--- Phân tích ---");
Console.WriteLine($"OOP:          {PhanTich.In(oop.DanhSachSV)}");
Console.WriteLine($"CTDL:         {PhanTich.In(ctdl.DanhSachSV)}");

Console.WriteLine($"Học cả hai:   {PhanTich.In(PhanTich.HocCaHai(oop, ctdl))}");
Console.WriteLine($"Chỉ học OOP:  {PhanTich.In(PhanTich.ChiHocA(oop, ctdl))}");
var tatCa = PhanTich.TatCa(oop, ctdl);
Console.WriteLine($"Toàn bộ ({tatCa.Count}): {PhanTich.In(tatCa)}");

Console.WriteLine("\n--- Hủy và đăng ký lại ---");
Console.WriteLine($"Hủy SV03: {oop.HuyDangKy("SV03")}");
Console.WriteLine($"SV05: {oop.DangKy("SV05")}");
Console.WriteLine($"OOP:  {PhanTich.In(oop.DanhSachSV)}");
Console.WriteLine($"OOP có SV03? {oop.CoDangKy("SV03")}");

