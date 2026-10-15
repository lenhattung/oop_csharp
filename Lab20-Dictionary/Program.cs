// Dictionary - Map
// Key -> Value
//Dictionary<int, string> thang = new Dictionary<int, string>();
//thang.Add(1, "Tháng Một");
//thang.Add(2, "Tháng Hai");

using Lab20_Dictionary;

Console.OutputEncoding = System.Text.Encoding.UTF8;
TuDienAnhViet td = new TuDienAnhViet();

td.Them(new TuVung("apple", "quả táo", LoaiTu.DanhTu));
td.Them(new TuVung("book", "quyển sách", LoaiTu.DanhTu));
td.Them(new TuVung("run", "chạy", LoaiTu.DongTu));
td.Them(new TuVung("beautiful", "đẹp", LoaiTu.TinhTu));
td.Them(new TuVung("quickly", "nhanh chóng", LoaiTu.TrangTu));

Console.WriteLine($"Từ điển ({td.SoLuong} từ):");
td.HienThi();

Console.WriteLine("\nTra 'run': " + td.Tra("run").ToString());
Console.WriteLine("\nTra 'running': " + (td.Tra("running")?.ToString() ?? "Không có"));

Console.WriteLine("\nCác danh từ:");
td.HienThiTheoLoai(LoaiTu.DanhTu);

Console.WriteLine("\nThống kê theo loại từ:");
foreach (var kv in td.ThongKe())
    Console.WriteLine($"  {kv.Key}: {kv.Value} từ");
