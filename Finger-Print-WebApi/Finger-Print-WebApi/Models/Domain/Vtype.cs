namespace Finger_Print_WebApi.Models.Domain
{
    public class Vtype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public IEnumerable<Vacation> Vacations { get; set; }
    }
}
