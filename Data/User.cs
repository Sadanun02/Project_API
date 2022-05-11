using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Models
{
    [Table("users",Schema="man")]
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string full_name { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string emp_num { get; set; }
    }
}