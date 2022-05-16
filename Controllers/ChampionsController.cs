using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSAdministration.Models;
using System.Collections.Generic;
using System.Linq;

namespace OSAdministration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChampionsController : ControllerBase
    {
        private readonly ILogger<ChampionsController> _logger;

        public ChampionsController(ILogger<ChampionsController> logger)
        {
            this._logger = logger;
        }

        List<Champion> champions = new List<Champion>
        {
            new() {Id = 1, FirstName = "Michael", LasName = "Schumacher", Sport = "Race"},
            new() {Id = 2, FirstName = "Juan", LasName = "Manuel", Sport = "Race"},
            new() {Id = 3, FirstName = "Alain", LasName = "Prost", Sport = "Race"},
            new() {Id = 4, FirstName = "Sebastian", LasName = "Vettel", Sport = "Race"},
            new() {Id = 5, FirstName = "Francis", LasName = "Ngannou", Sport = "MMA"},
            new() {Id = 6, FirstName = "Jackie", LasName = "Stewart", Sport = "Race"},
            new() {Id = 7, FirstName = "Jorge", LasName = "Masvidal", Sport = "MMA"},
            new() {Id = 8, FirstName = "Trevor", LasName = "Bryan", Sport = "Box"   },
            new() {Id = 9, FirstName = "Stipe", LasName = "Miocic", Sport = "MMA"},
            new() {Id = 10, FirstName = "Alexander", LasName = "Usyk", Sport = "Box"}
        };

        [HttpGet]
        public IActionResult GetChampions()
        {
            return Ok(champions);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var champion = champions.FirstOrDefault(c => c.Id == id);
            if (champion == default) return NotFound();
            return Ok(champion);
        }
    }
}
