public class Cau_02
{
    public static void Main2()
    {
        double diem = 0;
        do
        {
            Console.WriteLine("Nhap vao diem so tu 0 den 10: ");
            Double.TryParse(Console.ReadLine(), out diem);
        } while (diem < 0 || diem > 10);

        string ketQua = "";
        if (diem < 5)
        {
            ketQua = "Yeu";
        }
        else if (diem < 6.5)
        {
            ketQua = "Trung binh";
        }
        else if (diem < 8.0)
        {
            ketQua = "Kha";
        }
        else
        {
            ketQua = "Gioi";
        }

        Console.WriteLine($"Xep loai: {ketQua}");
    }
}

