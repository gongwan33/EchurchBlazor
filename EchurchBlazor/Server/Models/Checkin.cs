using System;
using System.ComponentModel.DataAnnotations;
using EchurchBlazor.Server.Models;

namespace echurch.Models
{
    public class Checkin
    {
        [Key]
        public int ID { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public Event Event { get; set; }
        public string Status { get; set; }
    }
}
