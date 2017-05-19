using System.ComponentModel.DataAnnotations;

namespace WebApiTests.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}