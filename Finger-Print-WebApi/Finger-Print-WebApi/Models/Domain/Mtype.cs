namespace Finger_Print_WebApi.Models.Domain
{
    public class Mtype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public IEnumerable<Mission> Missions { get; set; }
    }
}
