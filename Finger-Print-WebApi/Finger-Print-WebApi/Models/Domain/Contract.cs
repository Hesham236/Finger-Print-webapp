﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finger_Print_WebApi.Models.Domain
{
    public class Contract
    {
        public int Id { get; set; }
        public string type { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime end_date { get; set; }

        //Navigation Property
        public IEnumerable<Employee> Employees { get; set; }

    }
}
