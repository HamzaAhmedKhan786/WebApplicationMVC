using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.DataBase;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{   
    public class MoviesController : Controller
    {
        private readonly DBContext _db;

        public MoviesController(DBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
                IEnumerable<Movies> objNoviesList = _db.Movies;
            return View(objNoviesList);
        }
        //GET
        public IActionResult Add()
        {
           
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Movies movie)
        {
            if (ModelState.IsValid) {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}
