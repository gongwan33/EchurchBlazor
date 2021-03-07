using System;
using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Desc { get; set; }
        public string OtherParam { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; }
        public Church Church { get; set; }
        public string Repeat { get; set; }
    }
}
