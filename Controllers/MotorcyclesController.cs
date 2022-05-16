using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSAdministration.Models;
using System.Collections.Generic;
using System.Linq;

namespace OSAdministration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotorcyclesController : ControllerBase
    {
        private readonly ILogger<MotorcyclesController> _logger;

        public MotorcyclesController(ILogger<MotorcyclesController> logger)
        {
            this._logger = logger;
        }

        List<Motorcycle> motorcycles = new List<Motorcycle>
        {
            new() {Id = 1, Name = "Yamaha", Country = "Japan"},
            new() {Id = 2, Name = "Ducati", Country = "Italy"},
            new() {Id = 3, Name = "Honda", Country = "Japan"},
            new() {Id = 4, Name = "Kawasaki", Country = "Japan"},
            new() {Id = 5, Name = "Harley-Davidson", Country = "USA"},
            new() {Id = 5, Name = "Ural", Country = "USSR"},
            new() {Id = 6, Name = "Dnepr", Country = "USSR"},
            new() {Id = 7, Name = "Yava", Country = "USSR"},
            new() {Id = 8, Name = "Aprilla", Country = "Italy"},
            new() {Id = 9, Name = "Benelli", Country = "Italy"},
            new() {Id = 10, Name = "Indian Motorcycle", Country = "USA"}
        };

        [HttpGet]
        public IActionResult GetMotorcycles()
        {
            return Ok(motorcycles);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var motorcycle = motorcycles.FirstOrDefault(m => m.Id == id);
            if (motorcycle == default) return NotFound();
            return Ok(motorcycle);
        }
    }
}
