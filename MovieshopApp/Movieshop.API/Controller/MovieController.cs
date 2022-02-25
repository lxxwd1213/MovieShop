using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movieshop.API.ResponseModel;

namespace Movieshop.API.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    //ControllerBase is for API. Controller is for MVC
    public class MovieController : ControllerBase
    {
        List<MovieResponseModel> lst;
        public MovieController()
        {
            lst = new List<MovieResponseModel>
            {
            new MovieResponseModel { Id = 1, Name = "Die Hard", Ratings = 3.5f},
            new MovieResponseModel { Id = 2, Name = "Fast and Furious", Ratings = 4.0f},
            new MovieResponseModel { Id = 3, Name = "Hobbit", Ratings = 4.5f},
            };
        }
        [Route("list")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lst);
        }
        [Route("id/{id:int}")]
        public IActionResult Get(int id)
        {
            if (id < 1)
                return BadRequest();
            return Ok(lst.Where(x => x.Id == id).FirstOrDefault());
        }


        [Route("name/{name}")]// filter

        public IActionResult Get(string name)
        {
            if (string.IsNullOrEmpty(name))
                return NoContent();
            return Ok(lst.Where(x => x.Name == name).FirstOrDefault());
        }
        
    }
}
