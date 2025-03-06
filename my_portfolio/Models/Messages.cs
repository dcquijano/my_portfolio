using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace my_portfolio.Models
{
    public class Messages
    {
        [Key]
        public int? Id { get; set; }

        public string? Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }

    }
}
