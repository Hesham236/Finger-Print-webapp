namespace Finger_Print_WebApi.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public bool authority { get; set; }
    }
}
