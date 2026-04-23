using FinalWebAPI.Data;
using FinalWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AnimalController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id?}")]
        public async Task<ActionResult> GetAnimals(int? id)
        {
            if (id == null || id == 0)
            {
                var animals = await _context.Animals.Take(5).ToListAsync();
                return Ok(animals);
            }

            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return BadRequest();
            }

            return Ok(animal);
        }

        [HttpPost]
        public async Task<ActionResult> AddAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAnimals), new { id = animal.AnimalId }, animal);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAnimal(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);

            if (animal == null)
            {
                return BadRequest();
            }

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
