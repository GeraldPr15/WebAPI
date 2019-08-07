using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaDePagoController : ControllerBase
    {
        private readonly SistemaDePagoContext _context;

        public SistemaDePagoController(SistemaDePagoContext context)
        {
            _context = context;
        }

        // GET: api/SistemaDePago
        [HttpGet]
        public IEnumerable<SistemaDePago> GetSistemaDePago()
        {
            return _context.SistemaDePago;
        }

        // PUT: api/SistemaDePago/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemaDePago([FromRoute] int id, [FromBody] SistemaDePago sistemaDePago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sistemaDePago.Pago_ID)
            {
                return BadRequest();
            }

            _context.Entry(sistemaDePago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SistemaDePagoExists(id))
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

        // POST: api/SistemaDePago
        [HttpPost]
        public async Task<IActionResult> PostSistemaDePago([FromBody] SistemaDePago sistemaDePago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SistemaDePago.Add(sistemaDePago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSistemaDePago", new { id = sistemaDePago.Pago_ID }, sistemaDePago);
        }

        // DELETE: api/SistemaDePago/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSistemaDePago([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sistemaDePago = await _context.SistemaDePago.FindAsync(id);
            if (sistemaDePago == null)
            {
                return NotFound();
            }

            _context.SistemaDePago.Remove(sistemaDePago);
            await _context.SaveChangesAsync();

            return Ok(sistemaDePago);
        }

        private bool SistemaDePagoExists(int id)
        {
            return _context.SistemaDePago.Any(e => e.Pago_ID == id);
        }
    }
}