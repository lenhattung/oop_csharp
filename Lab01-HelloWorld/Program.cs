// Đặt bảng mã output và input sang UTF-8
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, World!");
Console.WriteLine("Le Nhat Tung!");
Console.WriteLine("TITV.com");

int tuoi;
tuoi = 18;

int nam = 2026;
string hoTen = "Le Nhat Tung";
double diemTB = 8.5;
bool daThiDau = true;
char xepLoai = 'G';

int a = 5;


Console.Write("Nhap tuoi cua ban: ");
int tuoi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Xin chào " + hoTen + ", bạn " + tuoi1 + " tuổi.");
Console.WriteLine($"Xin chào {hoTen}, bạn {tuoi1} tuổi");