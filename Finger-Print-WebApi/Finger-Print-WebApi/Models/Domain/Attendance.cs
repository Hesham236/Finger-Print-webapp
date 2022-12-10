namespace Finger_Print_WebApi.Models.Domain
{
    public class Attendance
    {
        public int id { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly in_time { get; set; }
        public TimeOnly out_time { get; set; }

        //Foreign key
        //public int Employee_id { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }

    }
}
