using Driederik.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driederik.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuperHeroController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private ISuperHeroService _superHeroService;

        public SuperHeroController(ILogger<WeatherForecastController> logger, ISuperHeroService service)
        {
            _logger = logger;
            _superHeroService = service;
        }

        //Create(post) Read(get) Update(put) Delete(delete)
        [HttpPost]
        public async Task AddHeroAsync(SuperHero superHero)
        {
            await _superHeroService.AddSuperHero(superHero);
        }

        [HttpGet]
        public async Task<IEnumerable<SuperHero>> GetHeroesAsync()
        {
            return await _superHeroService.GetSuperHeroes();
        }

        [HttpGet("{Id}")]
        public async Task<SuperHero> GetHeroAsync(int Id)
        {
            return await _superHeroService.GetSuperHero(Id);
        }

        [HttpPut("{SuperHero}")]
        public void UpdateHeroAsync(SuperHero superHero)
        {
            _superHeroService.UpdateSuperHero(superHero);
        }

        [HttpDelete("{SuperHero}")]
        public void DeleteHero(SuperHero superHero)
        {
            _superHeroService.DeleteSuperHero(superHero);
        }
    }
}