using StarWarsWebApplication.DTOs;

namespace StarWarsWebApplication.Validators
{
    public interface IPlanetValidate
    {
        bool IsValid(PlanetDto planetDto);
    }
}
