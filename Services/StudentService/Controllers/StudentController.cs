using Microsoft.AspNetCore.Mvc;

namespace StudentService.Controllers;


[ApiController]
[Route("[controller]")]
public class StudentController: ControllerBase
{
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Successful response" });
        }
}