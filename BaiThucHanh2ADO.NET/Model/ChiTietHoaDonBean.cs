namespace BaiThucHanh2ADO.NET.Model
{
    public class ChiTietHoaDonBean
    {
        public long MaCthd { get; private set; }
        public string MaHang { get; private set; }
        public long SoLuongMua { get;private set; }
        public long ThanhTien { get;private set; }
        public long MaHd { get;private set; }

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
