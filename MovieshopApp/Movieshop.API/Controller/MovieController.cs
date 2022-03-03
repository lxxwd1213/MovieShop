using ApplicationCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Repository;
using ApplicationCore.Contracts.Services;

namespace Movieshop.API.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    //ControllerBase is for API. Controller is for MVC
    public class MovieController : ControllerBase
    {

            private readonly IMovieService _movieService;
            public MovieController(IMovieService movieService)
            {
                _movieService = movieService;

            }

            [HttpGet]
            [Route("")]
            // http://localhost:73434/api/movies?pagesize=30&page=2&title=ave
            public IActionResult GetMoviesByPagination([FromQuery] int pageSize = 30, [FromQuery] int page = 1, string title = "")
            {
                var movies = _movieService.GetMoviesByPagination(pageSize, page, title);
                if (movies == null || movies.Count == 0)
                {
                    return NotFound($"no movies found for your search term {title}");
                }
                return Ok(movies);
            }

            [HttpGet]
            [Route("toprevenue")]
            public IActionResult GetTopRevenueMovies()
            {
                var movies = _movieService.GetTop30GrossingMovies();

                if (!movies.Any())
                {
                    return NotFound();
                }

                return Ok(movies);
            }
            [HttpGet]
            [Route("{id:int}")]
            public IActionResult Details(int id)
            {
                var movie = _movieService.GetMovieDetails(id);

                if (movie == null)
                    return NotFound();
                return Ok(movie);
            }
            [HttpGet]
            [Route("toprated")]
            public IActionResult GetAllMovies()
            {
                var movies = _movieService.GetTop30GRatedMovies();

                if (!movies.Any() || movies.Count == 0)
                {
                    return NotFound();
                }
                return Ok(movies);
            }
            [HttpGet]
            [Route("genre/{id:int}")]
            public IActionResult GetMovieByGenreId(int id)
            {
                var genreMovies = _movieService.MoviesSameGenre(id);

                if (!genreMovies.Any())
                {
                    return NotFound();
                }
                return Ok(genreMovies);
            }

            //-IMovieRepository _movieRepository;
            //-public MovieController(IMovieRepository movieRepository)
            //-{ 
            //-    _movieRepository = movieRepository;
            //-}


            //-[Route("{id}/name/{name}")]
            //-public IActionResult GetById(int id, string name)
            //-{
            //-    return Ok($"{id} - {name}");
            //-}

            //-[Route("GetByParam")]
            //-public IActionResult GetData(int id, string name)
            //-{
            //-    string str = "";
            //-    str += name;

            //-    return Ok("Result = " + str);
            //-}

            //-[Route("GetByBody")]
            //-public IActionResult GetData(Genre g)
            //-{
            //-    string str = "";
            //-    str += g.Name;

            //-    return Ok("Result = " + str);
            //-}

            //-[Route("GetByBoth")]
            //-public IActionResult GetByBoth(int rating, Genre g, [FromHeader]string jwt)
            //-{
            //-    return Ok(rating + " " + g.Name + " " + jwt);
            //-}

            //List<MovieResponseModel> lst;
            //public MovieController()
            //{
            //    lst = new List<MovieResponseModel>
            //    {
            //    new MovieResponseModel { Id = 1, Name = "Die Hard", Ratings = 3.5f},
            //    new MovieResponseModel { Id = 2, Name = "Fast and Furious", Ratings = 4.0f},
            //    new MovieResponseModel { Id = 3, Name = "Hobbit", Ratings = 4.5f},
            //    };
            //}

            //[Route("list")]
            //[HttpGet]
            //public IActionResult Get()
            //{
            //    return Ok(lst);
            //}

            //[Route("id/{id:int}")]
            //public IActionResult Get(int id)
            //{
            //    if (id < 1)
            //        return BadRequest();
            //    return Ok(lst.Where(x => x.Id == id).FirstOrDefault());
            //}

            //[Route("name/{name}")]// filter
            //public IActionResult Get(string name)
            //{
            //    if (string.IsNullOrEmpty(name))
            //        return NoContent();
            //    return Ok(lst.Where(x => x.Name == name).FirstOrDefault());
            //}

            //[Route("byquery")]
            //public IActionResult GetByQuery(int id, string name)
            //{
            //    return Ok(name);
            //}

            //[Route("byBody")]
            //public IActionResult GetData(Genre g)
            //{
            //    string str = "";
            //    str += g.Name;

            //    return Ok("Result = " + str);
            //}

        }
}
