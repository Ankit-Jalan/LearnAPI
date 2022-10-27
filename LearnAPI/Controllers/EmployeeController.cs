using LearnAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetAllEmployees()
        {
            return new List<EmployeeModel>() { 
                new EmployeeModel(){Id = 1,Name = "Ankit" },
                new EmployeeModel(){Id = 2,Name= "Maa"}
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel> { new EmployeeModel() { Id =1, Name = "Ankit"} });
        }
    }
}
