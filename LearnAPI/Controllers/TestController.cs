using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        
        public string Get(int index, int count)
        {
            return "Hello World Get" + index + count;
        }

        [Route("~/Test/Get2")]
        public string Get1()
        {
            return "Hello World Get1";
        }

        //[Route("Get/{id}/{authorId}")]
        //public string GetbyId(int id , int authorId)
        //{
        //    return "Hello World  " + id + " " + authorId;
        //}
    }
}
