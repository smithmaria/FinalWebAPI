using FinalWebAPI.Data;
using FinalWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CandleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<Candle>>> Get(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(await _context.Candles.Take(5).ToListAsync());
            }

            var candle = await _context.Candles.FindAsync(id);

            if (candle == null) { 
                return NotFound();
            }

            return Ok(candle);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Candle candle)
        {
            _context.Candles.Add(candle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = candle.CandleId }, candle);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Candle candle)
        {
            if (id != candle.CandleId)
            {
                return BadRequest();
            }

            _context.Entry(candle).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var candle = await _context.Candles.FindAsync(id);

            if (candle == null)
            {
                return BadRequest();
            }

            _context.Candles.Remove(candle);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
