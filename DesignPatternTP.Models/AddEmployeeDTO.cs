using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTP.Models
{
    public class AddEmployeeDTO
    {
        [Required]
        public required String FirstName { get; set; }
        [Required]
        public required String LastName { get; set; }
        [Required]
        [Range(1, double.PositiveInfinity, ErrorMessage = "The salary must be superior to 0.")]
        public required Double Salary { get; set; }
    }
}
