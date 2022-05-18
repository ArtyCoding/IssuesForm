using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [MinLength(5)]
        public string? Enterprice { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [MinLength(7)]
        public string? FullName { get; set; }
        public string? Age { get; set; }
        [MinLength(10)]
        public string? Text { get; set; }
    }
}
