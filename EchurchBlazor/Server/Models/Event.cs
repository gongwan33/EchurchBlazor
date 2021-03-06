using System;
using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Event
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public DateTime starttime { get; set; }
        public DateTime endtime { get; set; }
        public string desc { get; set; }
        public string other_param { get; set; }
        public string type { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string status { get; set; }
        public int? church_id { get; set; }
        public string repeat { get; set; }
    }
}
