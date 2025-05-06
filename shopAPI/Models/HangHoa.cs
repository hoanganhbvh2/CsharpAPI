namespace shopAPI.Models
{
    public class HangHoaM
    {
        public string TenHH { get; set; }
        public string DonGia { get; set; }
    }
    public class HangHoa: HangHoaM
    {
        public Guid MaHangHoa { get; set; }
    }
}

