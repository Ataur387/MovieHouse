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
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetActorsAsync(); 
            return View(data);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create([Bind("ProfilePictureURL, FirstName, LastName, Bio")] ActorModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddActorAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        //Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int Id)
        {
            var ActorDetails = await _service.GetActorByIdAsync(Id);
            if(ActorDetails == null)return View("Not Found");
            return View(ActorDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var ActorDetails = await _service.GetActorByIdAsync(Id);
            if (ActorDetails == null) return View("Not Found");
            await _service.DeleteActorAsync(Id);
            return RedirectToAction(nameof(Index));
        }
        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int Id)
        {
            var ActorDetails = await _service.GetActorByIdAsync(Id);
            if (ActorDetails == null) return View("Not Found");
            return View(ActorDetails);
        }
        //Get : Actors/Edit/1
        public async Task<IActionResult> Edit(int Id)
        {
            var ActorDetails = await _service.GetActorByIdAsync(Id);
            if (ActorDetails == null) return View("Not Found");
            return View(ActorDetails);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(int Id, [Bind("Id, ProfilePictureURL, FirstName, LastName, Bio")] ActorModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateActorAsync(Id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
