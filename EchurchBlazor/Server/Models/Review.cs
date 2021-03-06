using System;
namespace echurch.Models
{
    public class Review
    {
        public int id { get; set; }
        public int? user_id { get; set; }
        public double? rate { get; set; }
        public string content { get; set; }
        public int? church_id { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public int? event_id { get; set; }
        public string type { get; set; }
    }
}
