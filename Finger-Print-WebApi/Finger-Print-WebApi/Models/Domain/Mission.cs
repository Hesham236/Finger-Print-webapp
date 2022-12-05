namespace Finger_Print_WebApi.Models.Domain
{
    public class Mission
    {
        public int Id { get; set; }
        public string description { get; set; }
        public string purpose { get; set; }
        public int allowance { get; set; }
        public DateOnly start_date { get; set; }
        public DateOnly end_date { get; set; }

    }
}
