namespace BaiThucHanh2ADO.NET.Model
{
    public class ChiTietHoaDonBean
    {
        public long MaCthd { get;  set; }
        public string MaHang { get;  set; }
        public long SoLuongMua { get; set; }
        public long ThanhTien { get; set; }
        public long MaHd { get; set; }

        public ChiTietHoaDonBean(long maCthd, string maHang, long soLuongMua, long thanhTien, long maHd)
        {
            MaCthd = maCthd;
            MaHang = maHang;
            SoLuongMua = soLuongMua;
            ThanhTien = thanhTien;
            MaHd = maHd;
        }
    }
}
