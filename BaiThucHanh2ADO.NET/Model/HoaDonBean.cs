using System;

namespace BaiThucHanh2ADO.NET.Model
{
    public class HoaDonBean
    {
        public HoaDonBean(long maHoaDon, string maNhanVien, string maBan, DateTime ngayBan, bool daTraTien)
        {
            MaHoaDon = maHoaDon;
            MaNhanVien = maNhanVien;
            MaBan = maBan;
            NgayBan = ngayBan;
            DaTraTien = daTraTien;
        }

        public long MaHoaDon { get;  set; }
        public string MaNhanVien { get;  set; }
        public string MaBan { get;  set; }
        public DateTime NgayBan { get;  set; }
        public bool DaTraTien { get;  set; }

       
    }
}
