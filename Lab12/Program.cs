using Lab12;

List<PhuongTien> danhSachXe = new List<PhuongTien>
{
    new XeMay("59-X1-12345", "Nguyễn Văn A", 15000, "Xe tay ga"),
    new OToCon("51G-678.90", "Trần Thị B", 300000, 4),
    new XeMay("59-X2-99999", "Lê Văn C", 12000, "Xe số")
};

int[] soGioThue = { 30, 80, 5 }; // số giờ thuê tương ứng từng xe

for (int i = 0; i < danhSachXe.Count; i++)
{
    danhSachXe[i].InThongTinThue(soGioThue[i]);
    Console.WriteLine();
}