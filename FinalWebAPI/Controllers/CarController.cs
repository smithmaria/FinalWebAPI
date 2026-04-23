using FinalWebAPI.Data;
using FinalWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id?}")]
        public async Task<ActionResult> GetCars(int? id)
        {
            if (id == null || id == 0)
            {
                var cars = await _context.Cars.Take(5).ToListAsync();
                return Ok(cars);
            }

            var car = await _context.Cars.FindAsync(id);

            if (car == null)
            {
                return BadRequest();
            }

            return Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult> AddCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCars), new { id = car.CarId }, car);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCar(int id, Car car)
        {
            if (id != car.CarId)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);

            if (car == null)
            {
                return BadRequest();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
