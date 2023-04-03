using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginApp.Models.UserDto
{
    public class User
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
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
