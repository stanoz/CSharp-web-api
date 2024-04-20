using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarWarsWebApplication.DTOs;
using StarWarsWebApplication.Entities;
using StarWarsWebApplication.Services;

namespace StarWarsWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetService _planetService;
        public PlanetController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Planet>>> GetAllPlanets()
        {
            try
            {
                return Ok(await _planetService.GetAllPlanets());
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Planet>>> GetPlanet(int id)
        {
            try
            {
                return Ok(await _planetService.GetPlanetById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddPlanet(PlanetDto planetDto)
        {
            try
            {
                return Ok(await _planetService.AddPlanet(planetDto));
            }
            catch (ArgumentException ex)
            { 
            return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Planet>> UpadatePlanet(int id, PlanetDto planetDto)
        {
            try
            {
                return Ok(await _planetService.UpdatePLanet(id, planetDto));
            }
            catch (ArgumentException ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeletePlanet(int id)
        {
            try
            {
                return Ok(await _planetService.DeletePlanetById(id));
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
