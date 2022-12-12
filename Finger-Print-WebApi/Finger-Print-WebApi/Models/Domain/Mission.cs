using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finger_Print_WebApi.Models.Domain
{
    public class Mission
    {
        public int Id { get; set; }
        public string description { get; set; }
        public string purpose { get; set; }
        public int allowance { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime end_date { get; set; }

        //Foreign Key
        public int Employee_id { get; set; }
        public int Mtype_id { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }
        public Mtype Mtype { get; set; }

    }
}
