using Microsoft.IdentityModel.Tokens;
using StarWarsWebApplication.DTOs;
using System.Linq;

namespace StarWarsWebApplication.Validators
{
    public class PlanetValidator : IPlanetValidate
    {
        public bool IsValid(PlanetDto planetDto)
        {
            if (planetDto is null)
                return false;
            if (planetDto.Name.IsNullOrEmpty()) 
                return false;
            if (planetDto.Diameter <= 0)
                return false;
            if (planetDto.RotationPeriod <= 0)
                return false;
            if (planetDto.OrbitalPeriod <= 0)
                return false;
            if (planetDto.Gravity <= 0)
                return false;
            if (planetDto.Population <= 0)
                return false;
            if (planetDto.Climate.IsNullOrEmpty())
                return false;

            if (planetDto.Climate.Any(item => item.IsNullOrEmpty()))
            {
                return false;
            }

            if (planetDto.Terrain.IsNullOrEmpty())
                return false;

            if (planetDto.Terrain.Any(item => item.IsNullOrEmpty()))
                return false;

            return true;
        }
    }
}
