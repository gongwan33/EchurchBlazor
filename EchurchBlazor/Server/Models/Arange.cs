using System;
using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Arange
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int event_id { get; set; }
        [Required]
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        [Required]
        public string status { get; set; }
    }
}
