namespace Lab20_Dictionary
{
    internal class TuDienAnhViet
    {
        private Dictionary<string, TuVung> dsTu = new Dictionary<string, TuVung>();

        public bool Them(TuVung tu)
        {
            if (dsTu.ContainsKey(tu.TiengAnh)) return false;
            dsTu.Add(tu.TiengAnh, tu);
            return true;
        }

        public TuVung Tra(string tiengAnh)
        {
            return dsTu.TryGetValue(tiengAnh, out TuVung tu) ? tu : null;
        }

        public bool Xoa(string tiengAnh) => dsTu.Remove(tiengAnh);

        public void HienThi()
        {
            foreach (KeyValuePair<string, TuVung> kv in dsTu)
                Console.WriteLine($"  {kv.Key} -> {kv.Value.NghiaViet} [{kv.Value.Loai}]");
        }

        // Lọc theo loại từ: duyệt Values
        public void HienThiTheoLoai(LoaiTu loai)
        {
            foreach (TuVung tu in dsTu.Values)
                if (tu.Loai == loai)
                    Console.WriteLine("  " + tu);
        }

        // Thống kê số từ theo loại: dùng một Dictionary khác làm bộ đếm
        public Dictionary<LoaiTu, int> ThongKe()
        {
            Dictionary<LoaiTu, int> dem = new Dictionary<LoaiTu, int>();
            foreach (TuVung tu in dsTu.Values)
            {
                if (dem.ContainsKey(tu.Loai)) dem[tu.Loai]++;
                else dem[tu.Loai] = 1;
            }
            return dem;
        }

        public int SoLuong => dsTu.Count;
    }
}
