namespace Car_Rental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class my_lesson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        [StringLength(50)]
        public string user_name { get; set; }

        public int inst_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime lesson_days { get; set; }

        public TimeSpan lesson_time { get; set; }
    }
}
