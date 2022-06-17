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
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetProducers();
            return View(data);
        }

        //Get: Producers/Create

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create([Bind("ProfilePictureURL, FirstName, LastName, Bio")] ProducerModel Producer)
        {
            if (!ModelState.IsValid)
            {
                return View(Producer);
            }
            _service.AddProducer(Producer);
            return RedirectToAction(nameof(Index));
        }
        //Get: Producers/Details/1
        public async Task<IActionResult> Details(int Id)
        {
            var ProducerDetails = await _service.GetProducerByIdAsync(Id);
            if (ProducerDetails == null) return View("Not Found");
            return View(ProducerDetails);
        }

        //Get: Producers/Delete/1
        public async Task<IActionResult> Delete(int Id)
        {
            var ProducerDetails = await _service.GetProducerByIdAsync(Id);
            if (ProducerDetails == null) return View("Not Found");
            return View(ProducerDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var ProducerDetails = await _service.GetProducerByIdAsync(Id);
            if (ProducerDetails == null) return View("Not Found");
            await _service.DeleteProducerAsync(Id);
            return RedirectToAction(nameof(Index));
        }
        //Get : Producers/Edit/1
        public async Task<IActionResult> Edit(int Id)
        {
            var ProducerDetails = await _service.GetProducerByIdAsync(Id);
            if (ProducerDetails == null) return View("Not Found");
            return View(ProducerDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id, ProfilePictureURL, FirstName, LastName, Bio")] ProducerModel Producer)
        {
            if (!ModelState.IsValid) return View(Producer);
            await _service.UpdateProducerAsync(Id, Producer);
            return RedirectToAction(nameof(Index));
        }
    }
}
