using apbd19_cw6.Models;
using Microsoft.AspNetCore.Mvc;

namespace apbd19_cw6.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VisitsController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetAnimalVisits(int id)
    {
        return Ok(
            Database.Visits.Where(visit => visit.animal.Id == id)
        );
    }

    [HttpPost]
    public IActionResult InsertVisit(Visit visit)
    {
        Database.Visits.Add(visit);
        return Created();
    }
}