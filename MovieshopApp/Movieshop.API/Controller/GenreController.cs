using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;

namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService genreServie;

        public GenreController(IGenreService gen)
        {
            genreServie = gen;
        }
        [Route("list")]
        public IActionResult GetAll()
        {
            var data = genreServie.GetAllGenres();
            if (data == null)
            {
                return NotFound("No Genre available.");
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Post(GenreModel model)
        {
            if (genreServie.InsertGenre(model) != null)
                return Ok(model);
            return BadRequest();
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            if (genreServie.DeleteGenre(id) > 0)
                return Ok("Genre is deleted.");
            return NoContent();
        }
        [HttpPut]
        public IActionResult Put(GenreModel m)
        {
            if (genreServie.UpdateGenre(m) > 0)
                return Ok("Genre is updated");
            return NoContent();
        }
    }
}
