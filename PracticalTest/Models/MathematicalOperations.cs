using System.ComponentModel.DataAnnotations;

namespace PracticalTest.Models
{
    public class MathematicalOperations
    {
        [Key]
        public long Id { get; set; }
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public string MathOperation { get; set; }
        public decimal MathResult { get; set; }
        public string ResponseMessage { get; set; }
    }
}
