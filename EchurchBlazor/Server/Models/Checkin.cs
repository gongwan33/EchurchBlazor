using System;
using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Checkin
    {
        public int id { get; set; }
        public int user_id { get; set; }
        [Required]
        public string created { get; set; }
        public int? event_id { get; set; }
        public string status { get; set; }
    }
}
