Console.Write("Input a: ");
int a = 0;
Int32.TryParse(Console.ReadLine(), out a);
Console.Write("Input b: ");
int b = 0;
Int32.TryParse(Console.ReadLine(), out b);

MayTinh mt1 = new MayTinh();
Console.WriteLine($"{a} + {b} = {mt1.cong(a, b)}");
Console.WriteLine($"{a} + {b} + {a}= {mt1.cong(a, b, a)}");

// Ctrl + Chuột trái
