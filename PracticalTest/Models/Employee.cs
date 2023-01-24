using System.ComponentModel.DataAnnotations;

namespace PracticalTest.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}
