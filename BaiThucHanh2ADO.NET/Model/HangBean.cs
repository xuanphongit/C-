namespace BaiThucHanh2ADO.NET.Model
{
    public class HangBean
    {
        public HangBean(string maHang, string tenHang, long gia, long soLuong, string donViTinh)
        {
            MaHang = maHang;
            TenHang = tenHang;
            Gia = gia;
            SoLuong = soLuong;
            DonViTinh = donViTinh;
        }

        public string MaHang { get; set; }

        public string TenHang { get; set; }

        public long Gia { get; set; }

        public long SoLuong { get; set; }

        public string DonViTinh { get; set; }
    }
}
