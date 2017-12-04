namespace BaiThucHanh2ADO.NET.Model
{
    public class HienThiHoaDonBean
    {
        public long MaCtHd { get; set; }
        public string TenHang { get; set; }
        public long Gia { get; set; }
        public long SoLuongMua { get; set; }
        public long ThanhTien { get; set; }
        public string MaBan { get; set; }
        
        public HienThiHoaDonBean(long maCtHd, string tenHang, long gia, long soLuongMua, long thanhTien, string maBan)
        {
            MaCtHd = maCtHd;
            TenHang = tenHang;
            Gia = gia;
            SoLuongMua = soLuongMua;
            ThanhTien = thanhTien;
            MaBan = maBan;
            
        }
    }
}
