﻿//Auteur    : Loris habegger
//Date      : 05.05.2021
//Fichier   : ReferencerController.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WikiTechAPI.Models;

namespace WikiTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencersController : ControllerBase
    {
        private readonly WikiTechDBContext _context;

        public ReferencersController(WikiTechDBContext context)
        {
            _context = context;
        }

        // GET: api/Referencers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Referencer>>> GetReferencer()
        {
            return await _context.Referencer.ToListAsync();
        }

        // GET: api/Referencers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Referencer>> GetReferencer(int id)
        {
            var referencer = await _context.Referencer.FindAsync(id);

            if (referencer == null)
            {
                return NotFound();
            }

            return referencer;
        }

        [HttpGet("nbarticlebytag/{id}")]
        public int nbarticlebytag(int id) // article active 
        {
            return _context.Referencer.Include(x => x.IdArticleNavigation).Where(p => p.IdArticleNavigation.IsactiveArticle == true).Where(d => d.IdTag == id).Count();
        }

        // PUT: api/Referencers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReferencer(int id, Referencer referencer)
        {
            if (id != referencer.IdTag)
            {
                return BadRequest();
            }

            _context.Entry(referencer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReferencerExists(id))
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

        // POST: api/Referencers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Referencer>> PostReferencer(Referencer referencer)
        {

            _context.Referencer.Add(referencer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ReferencerExists(referencer.IdTag))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetReferencer", new { id = referencer.IdTag }, referencer);
        }

        // DELETE: api/Referencers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Referencer>> DeleteReferencer(int id)
        {
            var referencer = await _context.Referencer.FindAsync(id);
            if (referencer == null)
            {
                return NotFound();
            }

            _context.Referencer.Remove(referencer);
            await _context.SaveChangesAsync();

            return referencer;
        }

        private bool ReferencerExists(int id)
        {
            return _context.Referencer.Any(e => e.IdTag == id);
        }
    }
}
