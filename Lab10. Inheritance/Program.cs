using Lab10._Inheritance;

NhanVien nv = new NhanVien { Ten = "An", DiaChi = "Q1", LuongCoBan = 8000000 };
QuanLy ql = new QuanLy { Ten = "Bình", DiaChi = "Q3", LuongCoBan = 15000000, PhuCapQuanLy = 3000000 };
GiamDoc gd = new GiamDoc { Ten = "Chi", DiaChi = "Q7", LuongCoBan = 30000000, TyLeThuong = 20 };

nv.HienThi();
ql.HienThi();
gd.HienThi();