﻿using System;
using System.ComponentModel.DataAnnotations;
using EchurchBlazor.Server.Models;

namespace echurch.Models
{
    public class Arange
    {
        [Key]
        public int ID { get; set; }
        public ApplicationUser User { get; set; }
        public Event Event { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
