namespace BaiThucHanh2ADO.NET.Model
{
    public class BanBean
    {
        public BanBean(string maBan, string tenBan, int soGhe)
        {
            MaBan = maBan;
            TenBan = tenBan;
            SoGhe = soGhe;
        }

        public string MaBan { get; set; }

        public string TenBan { get; set; }

        public int SoGhe { get; set; }
    }
}
