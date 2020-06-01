using CsvHelper.Configuration.Attributes;
using System;

namespace KiemToan
{
    class Input2
    {
        [Index(0)]
        public String Ngay { get; set; }
        [Index(1)]
        public String SoHD { get; set; }
        [Index(2)]
        public String MaHang { get; set; }
        [Index(3)]
        public Double SL { get; set; }
        [Index(4)]
        public Double DonGia { get; set; }
        [Index(5)]
        public Double ThanhTien { get; set; }
        [Index(6)]
        public Double TienThueNop { get; set; }

    }
}
