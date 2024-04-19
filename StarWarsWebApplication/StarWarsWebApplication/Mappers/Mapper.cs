using StarWarsWebApplication.DTOs;
using StarWarsWebApplication.Entities;

namespace StarWarsWebApplication.Mappers
{
    public class Mapper : IMappper
    {
        public Planet MapToPlanet(PlanetDto planetDto)
        {
            Planet planet = new()
            {
                Name = planetDto.Name,
                Diameter = planetDto.Diameter,
                RotationPeriod = planetDto.RotationPeriod,
                OrbitalPeriod = planetDto.OrbitalPeriod,
                Gravity = planetDto.Gravity,
                Population = planetDto.Population,
                Climate = planetDto.Climate,
                Terrain = planetDto.Terrain
            };

            return planet;
        }
    }
}
