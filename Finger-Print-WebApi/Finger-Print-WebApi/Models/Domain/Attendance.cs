namespace Finger_Print_WebApi.Models.Domain
{
    public class Attendance
    {
        public int id { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly in_time { get; set; }
        public TimeOnly out_time { get; set; }
        public bool lates { get; set; }
    }
}
