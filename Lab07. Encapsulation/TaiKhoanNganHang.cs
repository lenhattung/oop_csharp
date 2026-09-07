namespace Lab07._Encapsulation
{
    public class TaiKhoanNganHang
    {
        // soTaiKhoan
        // tenChuTaiKhoan
        // soDu

        private string soTaiKhoan;
        private string chuTaiKhoan;
        private double soDu;

        public TaiKhoanNganHang()
        {
            this.soTaiKhoan = "";
            this.chuTaiKhoan = "";
            this.soDu = 0.0;
        }

        public TaiKhoanNganHang(string soTaiKhoan, string chuTaiKhoan, double soDuBanDau)
        {
            this.soTaiKhoan = soTaiKhoan;
            this.chuTaiKhoan = chuTaiKhoan;
            this.soDu = soDuBanDau > 0 ? soDuBanDau : 0;
        }
        // Getter và setter
        public string SoTaiKhoan
        {
            get { return soTaiKhoan; }
        }

        public string ChuTaiKhoan
        {
            get { return chuTaiKhoan.ToUpper(); }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Loi: Ten chu tai khoan khong duoc bo trong!");
                    return;
                }
                chuTaiKhoan = value;
            }
        }



        // Chỉ có get - số dư không được gán trực tiếp từ bên ngoài
        public double SoDu
        {
            get { return soDu; }
        }

        public void NapTien(double soTien)
        {
            if (soTien <= 0)
            {
                Console.WriteLine("Loi: So tien nap phai lon hon 0");
                return;
            }
            soDu += soTien;
            Console.WriteLine($"Da nap {soTien:N0} VND. So du hien tai la: {soDu:N0} VND");
        }

        public void RutTien(double soTien)
        {
            if (soTien <= 0)
            {
                Console.WriteLine("Loi: So tien rut phai lon hon 0");
                return;
            }

            if (soTien > soDu)
            {
                Console.WriteLine($"Loi: So du khong du ({soDu:N0} VND) de rut {soTien:N0} VND.");
                return;
            }
            soDu -= soTien;
            Console.WriteLine($"Da rut {soTien:N0} VND. So du hien tai la: {soDu:N0} VND");
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"So TK: {SoTaiKhoan} - Chu TK: {ChuTaiKhoan} - So du: {SoDu:N0} VND");
        }

    }
}
