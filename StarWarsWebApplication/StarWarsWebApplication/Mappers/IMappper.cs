using StarWarsWebApplication.DTOs;
using StarWarsWebApplication.Entities;

namespace StarWarsWebApplication.Mappers
{
    public interface IMappper
    {
        Planet MapToPlanet(PlanetDto planetDto);
    }
}
