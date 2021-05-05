﻿using Driederik.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driederik.Controllers
{
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

        [HttpPut("{SuperPower}")]
        public void UpdatePowerAsync(SuperPower superPower)
        {
            _superPowerService.UpdateSuperPower(superPower);
        }

        [HttpDelete("{SuperPower}")]
        public void DeletePower(SuperPower superPower)
        {
            _superPowerService.DeleteSuperPower(superPower);
        }
    }
}