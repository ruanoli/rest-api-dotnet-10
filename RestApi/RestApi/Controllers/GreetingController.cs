using System.Net.Security;
using Microsoft.AspNetCore.Mvc;
using RestApi.Models;

namespace RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    private static int _id;
    private static string _template = "Hello, {0}!";
    
    [HttpGet]
    public Greeting Get([FromQuery] string name = "World")
    {
        var id = Interlocked.Increment(ref _id);
        var content = string.Format(_template, name);
        
        return new Greeting(id, content);
    }
}