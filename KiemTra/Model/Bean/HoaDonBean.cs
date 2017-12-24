namespace KiemTra.Model.Bean
{
    public class HoaDonBean
    {
        public HoaDonBean(long maHoaDon, long maXe, long soLuongMua, long thanhTien, bool trangThai)
        {
            MaHoaDon = maHoaDon;
            MaXe = maXe;
            SoLuongMua = soLuongMua;
            ThanhTien = thanhTien;
            TrangThai = trangThai;
        }

        public long MaHoaDon { get; set; }
        public long MaXe { get; set; }
        public long SoLuongMua { get; set; }
        public long ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
//Test


