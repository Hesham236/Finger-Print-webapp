namespace Finger_Print_WebApi.Models.Domain
{
    public class Permission
    {
        public int Id { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }
        public string number { get; set; }

    }
}
