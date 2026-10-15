namespace Lab19_Set
{
    public class PhanTich
    {
        // A ∩ B
        public static HashSet<string> HocCaHai(HocPhan a, HocPhan b)
        {
            var kq = new HashSet<string>(a.DanhSachSV);  // sao chép A
            kq.IntersectWith(b.DanhSachSV);
            return kq;
        }

        // A \ B
        public static HashSet<string> ChiHocA(HocPhan a, HocPhan b)
        {
            var kq = new HashSet<string>(a.DanhSachSV);
            kq.ExceptWith(b.DanhSachSV);
            return kq;
        }

        // A ∪ B ∪ ...
        public static HashSet<string> TatCa(params HocPhan[] dsHP)
        {
            var kq = new HashSet<string>();
            foreach (HocPhan hp in dsHP)
                kq.UnionWith(hp.DanhSachSV);
            return kq;
        }

        // In có sắp xếp cho dễ đọc
        public static string In(IEnumerable<string> tap) =>
            string.Join(", ", new SortedSet<string>(tap));

    }
}
