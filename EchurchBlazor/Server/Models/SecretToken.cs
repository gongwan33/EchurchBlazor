using System.ComponentModel.DataAnnotations;

namespace echurch.Models
{
    public class SecretToken
    {
        [Key]
        public string Name { get; set; }
        public string Token { get; set; }
    }
}
