using CsvHelper.Configuration;

namespace KiemToan
{
    class MapTen : ClassMap<Output>
    {
        public MapTen()
        {
            Map(m => m.Ngay).Index(0).Name("Ngày");
            Map(m => m.SoHD).Index(1).Name("Số HD");
            Map(m => m.MaHang).Index(2).Name("Mã hàng");
            Map(m => m.TienThueNop).Index(6).Name("Tiền thuế nộp");
            Map(m => m.ThueKiemToan).Index(7).Name("Thuế kiểm toán");
        }
    }
}
