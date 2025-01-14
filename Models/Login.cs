using System.ComponentModel.DataAnnotations;

namespace testport.Models
{
    public class Login
    {
        
        public string name { get; set; }

        [Key]
        public string email { get; set; }

        public string message { get; set; }
    }
}
