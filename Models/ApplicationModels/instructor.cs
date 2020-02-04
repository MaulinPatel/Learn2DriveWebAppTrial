namespace Car_Rental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("instructor")]
    public partial class instructor
    {
        [StringLength(50)]
        public string inst_name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inst_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? inst_charge { get; set; }

        [StringLength(70)]
        public string inst_speciality { get; set; }

        [StringLength(20)]
        public string inst_car { get; set; }

        [Required]
        [StringLength(2)]
        public string inst_gender { get; set; }
    }
    public class Dropdownlist

    {

        public List<String> emplist { get; set; }

     
    }
}
