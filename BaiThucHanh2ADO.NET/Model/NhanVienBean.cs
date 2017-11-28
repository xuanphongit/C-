namespace BaiThucHanh2ADO.NET.Model
{
    public class NhanVienBean
    {
        public string MaNv { get;set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

        public string MatKhau { get; set; }

        public string Quyen { get; set; }
        public NhanVienBean(string maNv, string hoTen, string diaChi, string matKhau, string quyen)
        {
            MaNv = maNv;
            HoTen = hoTen;
            DiaChi = diaChi;
            MatKhau = matKhau;
            Quyen = quyen;
        }
    }
}
