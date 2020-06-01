using CsvHelper.Configuration.Attributes;
using System;

namespace KiemToan
{
    class Input1
    {
        [Index(0)]
        public String MaHang { get; set; }
        [Index(1)]
        public Double ThueSuat { get; set; }
    }
}
