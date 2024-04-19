using Microsoft.AspNetCore.Mvc;
using StarWarsWebApplication.DTOs;
using StarWarsWebApplication.Entities;

namespace StarWarsWebApplication.Services
{
    public interface IPlanetService
    {
        public Task<ActionResult<IEnumerable<Planet>>> GetAllPlanets();
        public Task<Planet> GetPlanetByIdAsync(int id);
        public Task<Planet> UpdatePLanet(int id, PlanetDto planetDto);
        public Task<int> AddPlanet(PlanetDto planetDto);
        public Task<int> DeletePlanetById(int id);
    }
}
