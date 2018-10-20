﻿using GameAPI.Data;
using GameAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaloonsController : ControllerBase
    {
        private readonly ITowersDefenseRepository _repo;

        public BaloonsController(ITowersDefenseRepository repo)
        {
            this._repo = repo;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBaloon(int id)
        {
            var baloon = await _repo.GetBaloon(id);
            return Ok(baloon);
        }
    }
}
