namespace ADO.Net.Model
{
    public class LoaiBean
    {
        public LoaiBean(string maloai,string tenloai)
        {
            Maloai = maloai;
            Tenloai = tenloai;
        }

        public string Maloai { get; set; }

        public string Tenloai { get; set; }
    }
}
