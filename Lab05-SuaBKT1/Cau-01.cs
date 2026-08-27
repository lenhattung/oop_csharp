public class Cau_01
{
    public static void Main1()
    {
        string TenSanPham;
        int SoLuong;
        double DonGia;

        Console.Write("Nhap vao ten san pham: ");
        TenSanPham = Console.ReadLine();

        try
        {
            Console.Write("Nhap vao so luong: ");
            SoLuong = Int32.Parse(Console.ReadLine());
            Console.Write("Don gia: ");
            DonGia = Double.Parse(Console.ReadLine());
            if (SoLuong < 0 || DonGia < 0)
            {
                Console.WriteLine("Du lieu khong hop le!");
            }

            Console.WriteLine($"Thanh tien: {SoLuong * DonGia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Du lieu khong hop le!");
        }
    }
}

