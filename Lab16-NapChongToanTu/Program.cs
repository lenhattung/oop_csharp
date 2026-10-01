using Lab16_NapChongToanTu;

//int a = 5;
//int b = 10;
//int c = a + b;
//Console.WriteLine(c);


//Point p1 = new Point(2, 3);
//Point p2 = new Point(4, 5);

//Point p3 = p1 + p2;
//p3.Show();

// Tạo hai phân số
Fraction f1 = new Fraction(1, 2);
Fraction f2 = new Fraction(1, 3);

Console.WriteLine("Fraction 1:");
f1.Show();

Console.WriteLine("Fraction 2:");
f2.Show();

// =========================
// Phép cộng
// =========================
Fraction sum = f1 + f2;

Console.WriteLine("\nAddition:");
Console.WriteLine(sum);

// =========================
// Phép trừ
// =========================
Fraction sub = f1 - f2;

Console.WriteLine("\nSubtraction:");
Console.WriteLine(sub);

// =========================
// Phép nhân
// =========================
Fraction mul = f1 * f2;

Console.WriteLine("\nMultiplication:");
Console.WriteLine(mul);

// =========================
// Phép chia
// =========================
Fraction div = f1 / f2;

Console.WriteLine("\nDivision:");
Console.WriteLine(div);

// =========================
// So sánh ==
// =========================
Fraction f3 = new Fraction(2, 4);

Console.WriteLine("\nComparison:");

if (f1 == f3)
{
    Console.WriteLine("f1 == f3");
}
else
{
    Console.WriteLine("f1 != f3");
}

// =========================
// So sánh !=
// =========================
if (f1 != f2)
{
    Console.WriteLine("f1 != f2");
}
else
{
    Console.WriteLine("f1 == f2");
}
