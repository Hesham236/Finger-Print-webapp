namespace Finger_Print_WebApi.Models.Domain
{
    public class Ptype
    {
        public int Id { get; set; }
        public string Name { get; set; }


        
        //Navigation Property
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
