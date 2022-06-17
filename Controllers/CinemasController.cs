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
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetCinemas();
            return View(data);
        }
        //Get : Movies/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create([Bind("Logo, Name, Description")] CinemaModel Cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(Cinema);
            }
            _service.AddCinema(Cinema);
            return RedirectToAction(nameof(Index));
        }
        //Get: Cinemas/Edit/1
        public async Task<IActionResult> Edit(int Id)
        {
            var CinemaDetails = await _service.GetCinemaByIdAsync(Id);
            if (CinemaDetails == null) return View("Not Found");
            return View(CinemaDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id, Logo, Name, Description")] CinemaModel Cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(Cinema);
            }
            await _service.UpdateCinemaAsync(Id, Cinema);
            return RedirectToAction(nameof(Index));
        }
        //Get : Cinemas/Delete/1
        public async Task<IActionResult> Delete(int Id)
        {
            var CinemaDetails = await _service.GetCinemaByIdAsync(Id);
            if (CinemaDetails == null) return View("Not Found");
            return View(CinemaDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var DirectorDetails = await _service.GetCinemaByIdAsync(Id);
            if (DirectorDetails == null) return View("Not Found");
            await _service.DeleteCinemaAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
