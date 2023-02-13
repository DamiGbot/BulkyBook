using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a Name")]
        [RegularExpression("^[A-Z][A-Za-z]+$", ErrorMessage = "First Letter  Alphabets are allowed")]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 50, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
