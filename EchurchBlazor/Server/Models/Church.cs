using System;
using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Church
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public double? lng { get; set; }
        public double? lat { get; set; }
        public string style { get; set; }
        public string desc { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string main_image { get; set; }
        public string other_param { get; set; }
    }
}
