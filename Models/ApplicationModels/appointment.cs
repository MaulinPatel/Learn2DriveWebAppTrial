namespace Car_Rental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class appointment
    {
        [Key]
        public int appointment_id { get; set; }

        public int inst_id { get; set; }

        [StringLength(50)]
        public string inst_name { get; set; }

        [Column(TypeName = "text")]
        public string inst_availibility { get; set; }

        public int? course_complition_day { get; set; }

        public int? hours_per_trip { get; set; }
    }
}
