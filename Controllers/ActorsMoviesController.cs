using Microsoft.AspNetCore.Mvc;
using MovieHouse.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Controllers
{
    public class ActorsMoviesController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsMoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.ActorMovies.ToList();
            return View();
        }
    }
}
