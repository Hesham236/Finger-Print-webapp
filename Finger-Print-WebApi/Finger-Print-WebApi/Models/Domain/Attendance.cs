using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finger_Print_WebApi.Models.Domain
{
    public class Attendance
    {
        public int id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime date { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan in_time { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan out_time { get; set; }

        //Foreign key
        public int Employee_id { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }

    }
}
