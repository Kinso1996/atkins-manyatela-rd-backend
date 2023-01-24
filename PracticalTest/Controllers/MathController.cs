using Microsoft.AspNetCore.Mvc;
using PracticalTest.Models;
using PracticalTest.ViewModels;

namespace PracticalTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MathController : ControllerBase
    {
        private PracticalTextContext _context;

        public MathController(PracticalTextContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ResponseModel MathResult(decimal firstNumber, decimal secondNumber, string mathOperation)
        {
            var response = new ResponseModel();
            var mathMatheticalOperations = new MathematicalOperations();

            try
            {
                mathMatheticalOperations.FirstNumber = firstNumber;
                mathMatheticalOperations.SecondNumber = secondNumber;
                mathMatheticalOperations.MathOperation = mathOperation.ToString();
                response.IsSuccess = true;

                if (mathMatheticalOperations.MathOperation == "Addition" || mathMatheticalOperations.MathOperation == "+")
                {
                    mathMatheticalOperations.MathResult = Math.Round(firstNumber+secondNumber,2);
                    mathMatheticalOperations.ResponseMessage= $"Result: {firstNumber} {mathOperation} {secondNumber} = {mathMatheticalOperations.MathResult}";
                    _context.Add<MathematicalOperations>(mathMatheticalOperations);
                    _context.SaveChanges();
                    response.Message = mathMatheticalOperations.ResponseMessage;
                }
                else if(mathMatheticalOperations.MathOperation == "Subtraction" || mathMatheticalOperations.MathOperation == "-")
                {
                    mathMatheticalOperations.MathResult = Math.Round(firstNumber - secondNumber, 2);
                    mathMatheticalOperations.ResponseMessage = $"Result: {firstNumber} {mathOperation} {secondNumber} = {mathMatheticalOperations.MathResult}";
                    _context.Add<MathematicalOperations>(mathMatheticalOperations);
                    _context.SaveChanges();
                    response.Message = mathMatheticalOperations.ResponseMessage;
                }
                else if (mathMatheticalOperations.MathOperation == "Division" || mathMatheticalOperations.MathOperation == "/")
                {
                    mathMatheticalOperations.MathResult = Math.Round(firstNumber / secondNumber, 2);
                    mathMatheticalOperations.ResponseMessage = $"Result: {firstNumber} {mathOperation} {secondNumber} = {mathMatheticalOperations.MathResult}";
                    _context.Add<MathematicalOperations>(mathMatheticalOperations);
                    _context.SaveChanges();
                    response.Message = mathMatheticalOperations.ResponseMessage;
                }
                else if (mathMatheticalOperations.MathOperation == "Multiplication" || mathMatheticalOperations.MathOperation == "*")
                {
                    mathMatheticalOperations.MathResult = Math.Round(firstNumber * secondNumber, 2);
                    mathMatheticalOperations.ResponseMessage = $"Result: {firstNumber} {mathOperation} {secondNumber} = {mathMatheticalOperations.MathResult}";
                    _context.Add<MathematicalOperations>(mathMatheticalOperations);
                    _context.SaveChanges();
                    response.Message = mathMatheticalOperations.ResponseMessage;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Invalid math operation";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        [HttpGet]
        public IEnumerable<string> HistoricalCalculations()
        {
            try
            {
                return _context.Set<MathematicalOperations>().OrderByDescending(x => x.Id).Select(x => x.ResponseMessage).ToList();
            }
            catch (Exception ex)
            {
                return new List<string>() { ex.Message.ToString() };
            }
        }
    }
}