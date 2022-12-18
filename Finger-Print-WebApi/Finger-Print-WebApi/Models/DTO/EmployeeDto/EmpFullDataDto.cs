using Finger_Print_WebApi.Models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finger_Print_WebApi.Models.DTO.EmployeeDto
{
    public class EmpFullDataDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string milatary_service_status { get; set; }
        public string national_id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime dob { get; set; }
        public string government { get; set; }
        public string address { get; set; }
        public string martial_status { get; set; }
        public int num_children { get; set; }
        public string social_insurance { get; set; }
        public string phone_number { get; set; }
        public string religion { get; set; }
        public string education { get; set; }
        public string job_description { get; set; }
        public byte[] photo { get; set; }


        public int Dept_id { get; set; }
        public int Contract_id { get; set; }

        //Navigation Prop
        //public Department Department { get; set; }
        //public Contract Contract { get; set; }
    }
}
