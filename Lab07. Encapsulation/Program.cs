using Lab07._Encapsulation;

TaiKhoanNganHang tk = new TaiKhoanNganHang("012345", "Nguyen Van A", 500000);

tk.HienThiThongTin();

tk.NapTien(200000);
tk.RutTien(1000000);
tk.RutTien(300000);
tk.RutTien(-500000);

tk.ChuTaiKhoan = "Le Nhat Tung";
tk.HienThiThongTin();
//tk.soDu = 1000000;