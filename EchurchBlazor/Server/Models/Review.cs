using System;
using System.ComponentModel.DataAnnotations;
using EchurchBlazor.Server.Models;

namespace echurch.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public ApplicationUser User { get; set; }
        public double? Rate { get; set; }
        public string Content { get; set; }
        public Church Church { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Event Event { get; set; }
        public string Type { get; set; }
    }
}
