﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            if (_unitOfWork.Makes == null)
            {
                return NotFound();
            }
            var makes = await _unitOfWork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            if (_unitOfWork.Makes == null)
            {
                return NotFound();
            }
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Makes.Update(make);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                var _make = await _unitOfWork.Makes.Get(q => q.Id == id);
                if (_make == null)
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

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostMake(Make make)
        {
            if (_unitOfWork.Makes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Makes'  is null.");
            }

            await _unitOfWork.Makes.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);
            if (make == null)
            {
                return NotFound();
            }
            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);
            return make == null;
        }
    }
}
