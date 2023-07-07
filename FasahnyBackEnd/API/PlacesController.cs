using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FasahnyBackEnd.Data;
using FasahnyBackEnd.Models;
using Newtonsoft.Json;

namespace FasahnyBackEnd.API
{
    [Route("api/[controller]")]
    [ApiController]

       public class PlacesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PlacesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Places
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Place>>> GetPlaces()
        {
            //return await _context.Places.ToListAsync();

            var startlist = @"{""Places"":";
            var result = await _context.Places.ToListAsync();
            var resultStr = JsonConvert.SerializeObject(result);
            var endlist = "}";
            return Content($"{startlist}{resultStr}{endlist}", "application/json");




        }

            // GET: api/Places/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Place>> GetPlace(int id)
            {
                var place = await _context.Places.FindAsync(id);


                if (place == null)
                {
                    return NotFound();
                }


            var startlist = @"{""Places"":";
            var resultStr = JsonConvert.SerializeObject(place);
            var endlist = "}";
            return Content($"{startlist}{resultStr}{endlist}", "application/json");

            //return place;
            }

       
        // PUT: api/Places/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlace(int id, Place place)
        {
            if (id != place.Id)
            {
                return BadRequest();
            }

            _context.Entry(place).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaceExists(id))
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

        // POST: api/Places
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Place>> PostPlace(Place place)
        {
            _context.Places.Add(place);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlace", new { id = place.Id }, place);
        }

        // DELETE: api/Places/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlace(int id)
        {
            var place = await _context.Places.FindAsync(id);
            if (place == null)
            {
                return NotFound();
            }

            _context.Places.Remove(place);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlaceExists(int id)
        {
            return _context.Places.Any(e => e.Id == id);
        }
    }
}
