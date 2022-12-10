namespace Finger_Print_WebApi.Models.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }

        //Navigation Property

        //one department have multiple employees
        public IEnumerable<Employee> Employees { get; set; } 

    }
}
