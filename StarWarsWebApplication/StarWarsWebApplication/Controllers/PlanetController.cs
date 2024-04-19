using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
