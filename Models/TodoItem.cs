using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoapi.Models
{
    [Table("item_labels",Schema = "man")]
    public class TodoItem
    {
        [Key]
        public string name { get; set; }
        [Key]
        public string val { get; set; }
        [Required]
        public string label_eng { get; set; }
        [Required]
        public string label_jpn { get; set; }
    }
}