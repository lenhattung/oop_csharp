public class Cau_03
{
    public static void Main()
    {
        int n;
        int[] a;

        do
        {
            Console.Write("Nhap vao so n (n>=1)");
            Int32.TryParse(Console.ReadLine(), out n);
        } while (n < 1);

        a = new int[n];
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"a[{i}]: ");
            Int32.TryParse(Console.ReadLine(), out a[i]);
        }

        int min = a[0];
        int max = a[0];
        double tong = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min) min = a[i];
            if (a[i] > max) max = a[i];
            tong = tong + a[i];
        }

        Console.WriteLine($"Max = {max}, Min = {min}");
        Console.WriteLine($"TBC = {tong / n}");
    }
}

