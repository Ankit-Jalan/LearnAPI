using LearnAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public IActionResult GetAnimals()
        {
            var animalas = new List<AnimalModel>()
            {
                new AnimalModel(){ Id = 1, Name = "Dog"},
                new AnimalModel(){ Id =2, Name = "Astha"}
            };
            return Ok(animalas);
        }
    }
}
