namespace Finger_Print_WebApi.Models.Domain
{
    public class Contract
    {
        public int Id { get; set; }
        public string type { get; set; }
        public DateOnly start_date { get; set; }
        public DateOnly end_date { get; set; }

        //Navigation Property
        public IEnumerable<Employee> Employees { get; set; }

    }
}
