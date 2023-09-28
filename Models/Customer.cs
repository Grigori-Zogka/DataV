using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataV.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter a valid Name")]
        public string Name { get; set; }

        
        [Column(TypeName = "int")]
        [Range(18, 120, ErrorMessage = "Customer must be an adult")]
        public int Age { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email Address")]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$", ErrorMessage = "Invalid Email Address")]
        [Column(TypeName = "varchar(150)")]
        public string Email { get; set; }
    }
}
