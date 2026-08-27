public class MyCalculator
{
    public void GPTBacNhat()
    {
        // ax + b = 0;
        double a, b, x;
        Console.WriteLine("Nhap vao a, va b la he so cua pt: ax + b = 0");
        Console.Write("a = ");
        Double.TryParse(Console.ReadLine(), out a);
        Console.Write("b = ");
        Double.TryParse(Console.ReadLine(), out b);

        if (a != 0)
        {
            x = -b / a;
            Console.WriteLine($"Phuong trinh co nghiem x = {x}");
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }

    public void GPTBacHai()
    {
        // ax^2 + bx + c = 0;
        // 6h45-7h00

    }

    public void GPTBacBa()
    {

    }

    public void GPTBacBon()
    {

    }

    public void SoNgayCuaThang()
    {
        // Nhap vao thang, nam
        // Hay cho biet thang do co bao nhieu ngay
        // Yeu cau su dụng switch case; co the ket hop voi if else
    }

    public void ShowMenu()
    {
        Console.WriteLine("======MENU======");
        Console.WriteLine("1. Giai phuong trinh bac nhat");
        Console.WriteLine("2. Giai phuong trinh bac hai");
        Console.WriteLine("3. Giai phuong trinh bac ba");
        Console.WriteLine("4. Giai phuong trinh bac bon");
        Console.WriteLine("5. Xac dinh so ngay cua mot thang");
        Console.WriteLine("9. Thoat khoi chuong trinh");

        int x = 9;
        Console.Write("Nhap vao lua chon cua ban: ");
        Int32.TryParse(Console.ReadLine(), out x);

        switch (x)
        {
            case 1:
                GPTBacNhat();
                break;
            case 2:
                GPTBacHai();
                break;

            case 3:

                break;
            case 4:
                break;

            case 5:
                SoNgayCuaThang();
                break;

            case 9:
                return;

            default:
                break;
        }

    }
}

