using Lab15_BaiKiemTra3;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;   // in 9,000,000

        // ---------- CÂU 2: đa hình qua List<NhanVien> (dữ liệu tạo sẵn) ----------
        Console.WriteLine("===== CAU 2: DANH SACH TAO SAN =====");
        NhanVienSanXuat sx1 = new NhanVienSanXuat("NV02", "Tran Thi B", 4000000, 15000);
        sx1.ThemSanLuong(100); sx1.ThemSanLuong(120); sx1.ThemSanLuong(80);
        NhanVienSanXuat sx2 = new NhanVienSanXuat("NV04", "Pham Van D", 4500000, 12000);
        sx2.ThemSanLuong(150); sx2.ThemSanLuong(-5); sx2.ThemSanLuong(130);   // -5 bị bỏ qua

        List<NhanVien> ds = new List<NhanVien>();
        ds.Add(new NhanVienVanPhong("NV01", "Nguyen Van A", 5000000, 20));
        ds.Add(sx1);
        ds.Add(new NhanVienVanPhong("NV03", "Le Van C", 6000000, 35));        // 35 -> 0
        ds.Add(sx2);

        foreach (NhanVien nv in ds)
            Console.WriteLine(nv);   // gọi ToString()/TinhLuong() của đúng lớp con

        // ---------- CÂU 3: nhập từ bàn phím vào QuanLyNhanVien ----------
        Console.WriteLine("\n===== CAU 3: NHAP DANH SACH =====");
        QuanLyNhanVien ql = new QuanLyNhanVien();
        int n;
        do { Console.Write("Nhap so nhan vien (n >= 4): "); }
        while (!int.TryParse(Console.ReadLine(), out n) || n < 4);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"--- Nhan vien thu {i} ---");
            Console.Write("Loai (1 - Van phong, 2 - San xuat): ");
            int loai = int.Parse(Console.ReadLine());
            Console.Write("Ma NV: "); string ma = Console.ReadLine();
            Console.Write("Ho ten: "); string ten = Console.ReadLine();
            Console.Write("Luong co ban: "); double lcb = double.Parse(Console.ReadLine());

            NhanVien nv;
            if (loai == 1)
            {
                Console.Write("So ngay cong: ");
                int ngay = int.Parse(Console.ReadLine());
                nv = new NhanVienVanPhong(ma, ten, lcb, ngay);
            }
            else
            {
                Console.Write("Don gia: ");
                double dg = double.Parse(Console.ReadLine());
                NhanVienSanXuat sx = new NhanVienSanXuat(ma, ten, lcb, dg);
                Console.Write("So ngay san xuat: ");
                int soNgay = int.Parse(Console.ReadLine());
                for (int j = 1; j <= soNgay; j++)
                {
                    Console.Write($"  San luong ngay {j}: ");
                    sx.ThemSanLuong(int.Parse(Console.ReadLine()));
                }
                nv = sx;
            }

            if (!ql.Them(nv))
            {
                Console.WriteLine("Trung ma NV, nhap lai!");
                i--;
            }
        }

        Console.WriteLine("\n--- Danh sach nhan vien ---");
        ql.InDanhSach();
        Console.WriteLine($"\nTong luong: {ql.TongLuong():N0}");
        Console.WriteLine($"Luong cao nhat: {ql.TimLuongCaoNhat()}");

        ql.SapXepGiamDanTheoLuong();
        Console.WriteLine("\n--- Sau khi sap xep giam dan theo luong ---");
        ql.InDanhSach();

        Console.WriteLine("\n--- Nhan vien san xuat ---");
        foreach (NhanVien nv in ql.LayDanhSachSanXuat()) Console.WriteLine(nv);
    }
}