namespace Lab20_Dictionary
{
    // ===== Loại từ =====
    enum LoaiTu
    {
        DanhTu,     // noun
        DongTu,     // verb
        TinhTu,     // adjective
        TrangTu     // adverb
    }

    // ===== Lớp TuVung (Word) =====
    class TuVung
    {
        public string TiengAnh { get; set; }
        public string NghiaViet { get; set; }
        public LoaiTu Loai { get; set; }

        public TuVung(string tiengAnh, string nghiaViet, LoaiTu loai)
        {
            TiengAnh = tiengAnh;
            NghiaViet = nghiaViet;
            Loai = loai;
        }

        public override string ToString() => $"{TiengAnh} ({Loai}): {NghiaViet}";
    }
}
