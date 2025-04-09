using apbd19_cw6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apbd19_cw6.Controllers
{
    // [controller] = Animals
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() // Ta metoda nie musi się nazywać get
        {
            var animals = Database.Animals;
            return Ok(animals);
        }
        
        // api/animals?name=Kot
        // [HttpGet] // Dzięki temu string jako parametr możemy użyć ?name=Kot
        // public IActionResult Get(string name) // Ta metoda nie musi się nazywać get
        // {
        //     var animals = Database.Animals;
        //     return Ok(animals);
        // }
        
        //api/animals/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var animals = Database.Animals.Where(animal => animal.AnimalId == id);
            return Ok(animals);
        }

        // POST api/aniamals { "AnimalId":4, "Name": "Zbych" }
        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }
    }
}