using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieHouse.Data;
using MovieHouse.Data.Services;
using MovieHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieHouse.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly IDirectorsService _service;
        public DirectorsController(IDirectorsService service) => _service = service;
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetDirectors();
            return View(data);
        }

        //Get : Directors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("ProfilePictureURL, FirstName, LastName, Bio")] DirectorModel Director)
        {
            if (!ModelState.IsValid)
            {
                return View(Director);
            }
            _service.AddDirector(Director);
            return RedirectToAction(nameof(Index));
        }
        //Get : Directors/Edit/1
        public async Task<IActionResult> Edit(int Id)
        {
            var DirectorDetails = await _service.GetDirectorByIdAsync(Id);
            if (DirectorDetails == null) return View("Not Found");
            return View(DirectorDetails);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(int Id, [Bind("Id, ProfilePictureURL, FirstName, LastName, Bio")] DirectorModel Director)
        {
            if (!ModelState.IsValid)
            {
                return View(Director);
            }
            await _service.UpdateDirectorAsync(Id, Director);
            return RedirectToAction(nameof(Index));
        }
        //Get : Directors/Details/1
        public async Task<IActionResult> Details(int Id)
        {
            var DirectorDetails = await _service.GetDirectorByIdAsync(Id);
            if (DirectorDetails == null) return View("Not Found");
            return View(DirectorDetails);
        }
        //Get : Directors/Delete/1
        public async Task<IActionResult> Delete(int Id)
        {
            var DirectorDetails = await _service.GetDirectorByIdAsync(Id);
            if (DirectorDetails == null) return View("Not Found");
            return View(DirectorDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            
            await _service.DeleteDirectorAsync(Id);
            return RedirectToAction(nameof(Index));
        }

    }
}
