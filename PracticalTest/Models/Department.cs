using System.ComponentModel.DataAnnotations;

namespace PracticalTest.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal MaxSalary { get; set; }
    }
}
