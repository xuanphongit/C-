using System;

namespace BaiThucHanh2ADO.NET.Model
{
    public class VThongKeBean
    {
        public String TenHang { get; set; }
        public long Gia { get; set; }
        public long SoLuongMua { get; set; }
        public long ThanhTien { get; set; }
        public DateTime NgayBan { get; set; }

        public VThongKeBean(string tenHang, long gia, long soLuongMua, long thanhTien, DateTime ngayBan)
        {
            TenHang = tenHang;
            Gia = gia;
            SoLuongMua = soLuongMua;
            ThanhTien = thanhTien;
            NgayBan = ngayBan;
        }
    }
}