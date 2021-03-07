using System;
using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Church
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public double? Lng { get; set; }
        public double? Lat { get; set; }
        public string Style { get; set; }
        public string Desc { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string MainImage { get; set; }
        public string OtherParam { get; set; }
    }
}
