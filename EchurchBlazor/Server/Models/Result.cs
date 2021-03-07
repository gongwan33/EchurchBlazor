using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class Result
    {
        [Key]
        public int Code { get; set; }
        public int ResourceID { get; set; }
        public string Msg { get; set; }
        public string Other { get; set; }
    }
}
