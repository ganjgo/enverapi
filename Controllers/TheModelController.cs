using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mujo.DTOs;
using mujo.Interfaces;
using mujo.Models;

namespace mujo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TheModelController : ControllerBase
    {
        private readonly ITheModelRepository _theModelConext;
        public TheModelController(ITheModelRepository theModelContext)
        {
            _theModelConext = theModelContext;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllTheModels()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Hueston we have problem!");
            }

            var theModels = await _theModelConext.GetTheModels();

            return Ok(theModels);
        }

        [HttpPost]

        public async Task<IActionResult> CreateNewTheModel([FromBody] NewTheModelDTO newTheModelDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Hueston we have while creating The Model!");
            }

            var toTheModel = new TheModel {
                Content = newTheModelDTO.Content,
            };

            var newTheModel = await _theModelConext.CreateTheModel(toTheModel);

            return Ok(newTheModel);

        }





    }
}