using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.Model.Bean
{
    public class OToBean
    {
        public OToBean(long maXe, string tenXe, long soLuongTrongKho, long gia, long maHang)
        {
            MaXe = maXe;
            TenXe = tenXe;
            SoLuongTrongKho = soLuongTrongKho;
            Gia = gia;
            MaHang = maHang;
        }
        public long MaXe { get; set; }
        public string TenXe { get; set; }
        public long SoLuongTrongKho { get; set; }
        public long Gia { get; set; }
        public long MaHang { get; set; }

    }
}
