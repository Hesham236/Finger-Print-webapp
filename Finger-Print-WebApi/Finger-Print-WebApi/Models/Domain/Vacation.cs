using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finger_Print_WebApi.Models.Domain
{
    public class Vacation
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime end_date { get;set; }
        public string notes { get; set; }


        //Foreign Key
        public int Employee_id { get; set; }
        public int VType_id { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }
        public Vtype Vtype { get; set; }
    }
}
