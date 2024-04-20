using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StarWarsWebApplication.Data;
using StarWarsWebApplication.DTOs;
using StarWarsWebApplication.Entities;
using StarWarsWebApplication.Mappers;
using StarWarsWebApplication.Validators;

namespace StarWarsWebApplication.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly DataContext _dataContext;
        private readonly IMappper _mapper;
        private readonly IPlanetValidate _planetValidate;
        public PlanetService(DataContext dataContext, IMappper mapper, IPlanetValidate planetValidate)
        {
            _dataContext = dataContext;
            _mapper = mapper;
            _planetValidate = planetValidate;
        }

        public async Task<ActionResult<IEnumerable<Planet>>> GetAllPlanets()
        {
            var allPlanets = await _dataContext.StarWarsPlanets.ToListAsync();
            if (allPlanets.IsNullOrEmpty())
            {
                throw new ArgumentException("There are no planets in database!");
            }
            return allPlanets;
        }

        public async Task<Planet> GetPlanetById(int id)
        {
            var allPlanets = await _dataContext.StarWarsPlanets.ToListAsync();
            if (allPlanets.IsNullOrEmpty())
            {
                throw new ArgumentException("There are no planets in database!");
            }
            var planet = allPlanets.First(planet => planet.Id == id);

            if (planet is null)
            {
                throw new ArgumentNullException($"Planet of id: {id} not found!");
            }

            return planet;
        }
        public async Task<int> AddPlanet(PlanetDto planetDto)
        {
            if (!_planetValidate.IsValid(planetDto))
            {
                throw new ArgumentException($"Planet {nameof(planetDto)} is invalid!");
            }

            var planet = _mapper.MapToPlanet(planetDto);
            _dataContext.StarWarsPlanets.Add(planet);
            await _dataContext.SaveChangesAsync();
            return planet.Id;
        }

        public async Task<Planet> UpdatePLanet(int id, PlanetDto updatedPlanetDto)
        {
            var dbPlanet = await _dataContext.StarWarsPlanets.FindAsync(id);
            if (dbPlanet is null) 
            {
                throw new ArgumentNullException(nameof(dbPlanet));
            }
            if (!_planetValidate.IsValid(updatedPlanetDto))
            {
                throw new ArgumentException($"Planet {nameof(updatedPlanetDto)} is invalid!");
            }

            dbPlanet = _mapper.MapToPlanet(updatedPlanetDto);
            dbPlanet.Id = id;

            await _dataContext.SaveChangesAsync();

            return dbPlanet;
            
        }

        public async Task<int> DeletePlanetById(int id)
        {
            var dbPlanet = await _dataContext.StarWarsPlanets.FindAsync(id);
            if (dbPlanet is null)
            {
                throw new ArgumentNullException(nameof(dbPlanet));
            }

            _dataContext.StarWarsPlanets.Remove(dbPlanet);
            await _dataContext.SaveChangesAsync();

            return id;
        }
    }
}
