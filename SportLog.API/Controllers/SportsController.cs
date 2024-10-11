using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportLog.Entities.DTOs;
using SportLog.Entities.Mapping;
using SportLog.Entities.Models;
using SportLog.API.Services;
using SportLog.API.Interfaces;

namespace SportLog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {

        private readonly ISportRepository sportRepository;

        public SportsController(ISportRepository sportRepository)
        {
            this.sportRepository = sportRepository;
        }

        // GET: api/Sports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sport>>> GetSport()
        {
            return Ok(await sportRepository.GetAllAsync());
        }


        // GET: api/Sports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sport>> GetSport(int id)
        {
            var sport = await sportRepository.GetByIdAsync(id);

            //var sport = await _context.Sports.FindAsync(id);

            if (sport == null)
            {
                return NotFound();
            }

            return Ok(sport);
        }

        /*
        // PUT: api/Sports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSport(int id, SportDTO sportDTO)
        {
            var sport = await _context.Sports.FindAsync(id);

            if (sport == null || id != sport.Id)
            {
                return BadRequest();
            }

            sport = SportMapping.Map(sportDTO, sport);

            _context.Entry(sport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Sports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SportDTO>> PostSport([FromBody] SportDTO sportDTO)
        {
            var sport = SportMapping.Map(sportDTO);

            _context.Sports.Add(sport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSport", new { id = sport.Id }, sport);
        }

        // DELETE: api/Sports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSport(int id)
        {
            var sport = await _context.Sports.FindAsync(id);
            if (sport == null)
            {
                return NotFound();
            }

            _context.Sports.Remove(sport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SportExists(int id)
        {
            return _context.Sports.Any(e => e.Id == id);
        }
        */
    }
}
