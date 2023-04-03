using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loginApp.Models.UserDto
{
    public class UserDto
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        [MinLength(3)]
        public string nickname { get; set; }
        public string email { get; set; }
        [MinLength(6)]
        public string passowrd { get; set; }
        public string avatar { get; set; }
    }
}
