namespace Finger_Print_WebApi.Models.Domain
{
    public class Vacation
    {
        public int Id { get; set; }
        public DateOnly start_date { get; set; }
        public DateOnly end_date { get;set; }
        public string notes { get; set; }


        //Foreign Key
        //public int Employee_id { get; set; }
        //public int VType_id { get; set; }
        //Navigation Property
        public Employee Employee { get; set; }
        public Vtype Vtype { get; set; }
    }
}
