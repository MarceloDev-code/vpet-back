using Microsoft.AspNetCore.Mvc;
using VPetBackend.Data;
using VPetBackend.Models;

namespace VPetBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Random _rand = new();

        public PetsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pet>> GetPets()
        {
            return Ok(_context.Pets.ToList());
        }

        [HttpPost]
        public ActionResult<Pet> CreatePet([FromBody] Pet newPet)
        {
            newPet.Stats.Strength = _rand.Next(10, 20);
            newPet.Stats.Intelligence = _rand.Next(10, 20);
            newPet.Stats.Dexterity = _rand.Next(10, 20);
            newPet.Stats.Speed = _rand.Next(10, 20);
            newPet.Stats.Endurance = _rand.Next(10, 20);
            newPet.Stats.Charisma = _rand.Next(10, 20);

            _context.Pets.Add(newPet);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPets), new { id = newPet.Id }, newPet);
        }
    }
}
