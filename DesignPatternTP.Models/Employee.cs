using System.ComponentModel.DataAnnotations;

namespace DesignPatternTP.Models
{
    public class Employee
    {
        [Required]
        public required String ID { get; set; }
        [Required]
        public required String FirstName { get; set; }
        [Required]
        public required String LastName { get; set; }
        [Required]
        [Range(1, double.PositiveInfinity, ErrorMessage = "The salary must be superior to 0.")]
        public required Double Salary { get; set; }
    }
}
