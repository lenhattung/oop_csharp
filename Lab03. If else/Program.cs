// if (bieu thuc dieu kien) { cac cau lenh };
// if (bieu thuc dieu kien) { cac cau lenh } else { cac cau lenh };
//Console.Write("Nhap vao bien x: ");
//int x;
//Int32.TryParse(Console.ReadLine(), out x); ;

//if (x % 2 == 0)
//{
//    Console.WriteLine($"{x} la so chan");
//}
//else
//{
//    Console.WriteLine($"{x} la so le");
//}

// Toan tu dieu kien: (bieu thuc)? ket qua A : ket qua B

/*
string ketQua = (x % 2 == 0) ? "chan" : "le";
Console.WriteLine($"{x} la {ketQua}");
*/

/*

if (bieu thuc dieu kien 1) {
    cac cau lenh khi bieu thuc dieu kien 1 dung
}else if (btdk 2){
    cac cau lenh khi bieu thuc dieu kien 2 dung
} ... {
    cac cau lenh khi bieu thuc dieu kien ... dung
} else {
    cac cau lenh khi tat cac cac bieu thuc ben tren bi sai
}
 

if (bieu thuc dieu kien){
    if(btkd) {
        if(btdk){
            cac cau lenh
        }
    }
}

*/

MyCalculator g = new MyCalculator();
g.ShowMenu();
