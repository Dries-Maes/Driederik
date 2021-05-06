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
    //letters aanvullen om naam van class aan te passen in Swagger
    public class SuperPowerController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private ISuperPowerService _superPowerService;

        public SuperPowerController(ILogger<WeatherForecastController> logger, ISuperPowerService service)
        {
            _logger = logger;
            _superPowerService = service;
        }

        //Create(post) Read(get) Update(put) Delete(delete)
        [HttpPost]
        public async Task AddPowerAsync(SuperPower superPower)
        {
            await _superPowerService.AddSuperPower(superPower);
        }

        [HttpGet]
        public async Task<IEnumerable<SuperPower>> GetPowersAsync()
        {
            return await _superPowerService.GetSuperPowers();
        }

        [HttpGet("{Id}")]
        public async Task<SuperPower> GetPowerAsync(int Id)
        {
            return await _superPowerService.GetSuperPower(Id);
        }

        [HttpPut]
        public void UpdatePowerAsync(SuperPower superPower)
        {
            _superPowerService.UpdateSuperPower(superPower);
        }

        [HttpDelete("{Id}")]
        public async Task DeletePowerAsync(int id)
        {
            await _superPowerService.DeleteSuperPowerAsync(id);
        }
    }
}