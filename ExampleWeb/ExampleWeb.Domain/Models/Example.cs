using System.ComponentModel.DataAnnotations;

namespace ExampleWeb.Domain.Models
{
    public class Example
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PropertyName1 { get; set; }

        public int PropertyName2 { get; set; }

        public string PropertyName3 { get; set; }
    }
}
