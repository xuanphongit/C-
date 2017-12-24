

namespace KiemTra.Model.Bean
{
    public class HangBean
    {
        public HangBean(long maHang, string tenHang)
        {
            MaHang = maHang;
            TenHang = tenHang;
        }
        public long MaHang { get; set; }
        public string TenHang { get; set; }

    }
}




