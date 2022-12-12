using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finger_Print_WebApi.Models.Domain
{
    public class Permission
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime date { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan time { get; set; }
        public string number { get; set; }


        //Foreign Key
        public int Employee_id { get; set; }
        public int Ptype_id { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }
        public Ptype Ptype { get; set; }

    }
}
