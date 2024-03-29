﻿using Microsoft.AspNetCore.Mvc;
using MySportShope.API.Models;
using MySportShope.API.Repositories;

namespace MySportShope.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repo;
      

        public CategoryController(ICategoryRepository _repo)
        {
           
            this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
        }
        [HttpGet]
        public IActionResult Getall()
        {
            var result = _repo.FindAll().ToList();
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id)
        {
            var result = _repo.FindByCodition(u => u.ID == id).FirstOrDefault();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Creatr(Category item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var result = _repo.Create(item);
            return Created("user", result);
        }
        [HttpPut]
        public IActionResult Update(Category item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var exists = _repo.FindByCodition(u => u.ID == item.ID).Any();
            if (!exists)
            {
                return NotFound();
            }

            _repo.Update(item);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delet(int id)
        {
            var user = _repo.FindByCodition(u => u.ID == id).FirstOrDefault ();
            if (user==null)
            {
                return NotFound();
            }
            _repo.Delete(user);
            return NoContent();
        }


    }
}
