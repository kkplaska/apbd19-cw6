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
        public IActionResult Get() // 1. pobieranie listy zwierząt
        {
            var animals = Database.Animals;
            return Ok(animals);
        }
        
        //GET api/animals/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id) // 2.pobieranie danych konkretnego zwierzęcia po id 
        {
            var animals = Database.Animals.Where(animal => animal.Id == id);
            return Ok(animals);
        }

        // POST api/animals { "Id":4, "Name": "Zbych" }
        [HttpPost] // 3. dodawanie zwierzęcia
        public IActionResult PostAnimal(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }

        // PUT api/animals/{id} { "AnimalId":4, "Name": "Zbych" }
        [HttpPut("{id:int}")] // 4. edycja danych zwierzęcia
        public IActionResult PutAnimal(int id, [FromBody] Animal animal)
        {
            var updatedAnimal = Database.Animals.FirstOrDefault(updatedAnimal => updatedAnimal.Id == id);
            
            if (updatedAnimal == null) return NotFound();
            
            updatedAnimal.Id = animal.Id;
            updatedAnimal.Name = animal.Name;
            updatedAnimal.Category = animal.Category;
            updatedAnimal.Weight = animal.Weight;
            updatedAnimal.FurColor = animal.FurColor;
            
            return NoContent();
        }

        //DELETE api/animals/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) // 5. usuwanie zwierzęcia
        {
            var animal = Database.Animals.FirstOrDefault(animal => animal.Id == id);
            if (animal == null) return NotFound();
            Database.Animals.Remove(animal);
            return Ok();
        }

        //GET api/animals/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetAnimByName(string name)
        {
            return Ok(Database.Animals.Where(animal => animal.Name == name));
        }
        
        
        
        
        
    }
}