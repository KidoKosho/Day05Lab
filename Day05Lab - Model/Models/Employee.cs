using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Gender { get; set; }

        [Phone]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        public bool Status { get; set; }
    }
}
