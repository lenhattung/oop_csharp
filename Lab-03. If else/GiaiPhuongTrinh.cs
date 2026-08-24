public class GiaiPhuongTrinh
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

    }
}

