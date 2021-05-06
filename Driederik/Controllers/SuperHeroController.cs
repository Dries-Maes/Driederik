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
            await _superHeroService.AddSuperHeroAsync(superHero);
        }

        [HttpGet]
        public async Task<IEnumerable<SuperHero>> GetHeroesAsync()
        {
            return await _superHeroService.GetSuperHeroesAsync();
        }

        [HttpGet("{Id}")]
        public async Task<SuperHero> GetHeroAsync(int Id)
        {
            return await _superHeroService.GetSuperHeroAsync(Id);
        }

        [HttpPut("{Id}")]
        public async Task UpdateHeroAsync(int id)
        {
           await _superHeroService.UpdateSuperHeroAsync(id);
        }

        [HttpDelete("{Id}")]
        public async Task DeleteHeroAsync(int id)
        {
            await _superHeroService.DeleteSuperHeroAsync(id);
        }
    }
}