using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using RestApi.Helpers;
using RestApi.Services;

namespace RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private readonly MathService _service;
    
    public MathController(MathService service)
    {
        _service = service;
    }
    
    [HttpGet("Sum/{firstNumber}/{secondNumber}")]
    public ActionResult Sum(string firstNumber, string secondNumber)
    {

        if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var result = _service.Sum(firstNumber, secondNumber);
            return Ok(result);

        }
        
        return BadRequest("Não é um número");
    }

    [HttpGet("Substract/{firstNumber}/{secondNumber}")]
    public ActionResult Substract(string firstNumber, string secondNumber)
    {
        if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var result = _service.Substract(firstNumber, secondNumber);
            return Ok(result);

        }
        
        return BadRequest("Não é um número");
    }
    
    [HttpGet("Multiplication/{firstNumber}/{secondNumber}")]
    public ActionResult Multiplication(string firstNumber, string secondNumber)
    {
        if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var result = _service.Multiplication(firstNumber, secondNumber);
            return Ok(result);

        }
        
        return BadRequest("Não é um número");
        
        return BadRequest("Numbers must be numeric");
    }

    [HttpGet("Division/{firstNumber}/{secondNumber}")]
    public ActionResult Division(string firstNumber, string secondNumber)
    {
        if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var result = _service.Division(firstNumber, secondNumber);
            return Ok(result);

        }
        
        return BadRequest("Não é um número");
    }
    
    [HttpGet("squareRoot/{number}")]
    public ActionResult SquareRoot(string number)
    {
        if (NumberHelper.IsNumeric(number))
        {
            var result = _service.Sqr(number);
            return Ok(result);

        }
        
        return BadRequest("Não é um número");
    }
    
    [HttpGet("Average/{firstNumber}/{secondNumber}")]
    public ActionResult Average(string firstNumber, string secondNumber)
    {
        if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
        {
            var result = _service.Average(firstNumber, secondNumber);
            return Ok(result);

        }
        
        return BadRequest("Não é um número");
    }
    
    
}