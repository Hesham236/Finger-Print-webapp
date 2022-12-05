namespace Finger_Print_WebApi.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string milatary_service_status { get; set; }
        public string national_id { get; set; }
        public DateOnly dob { get; set; }
        public string government { get; set; }
        public string address { get; set; }
        public string martial_status { get; set; }
        public int num_children { get; set; }
        public string? social_insurance { get; set; }
        public string phone_number { get; set; }
        public string religion { get; set; }
        public string education { get; set; }
        public string job_description { get; set; }
        public byte[] photo { get; set; }



    }
}
