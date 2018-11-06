using GameAPI.Data;
using GameAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using GameAPI.Dtos;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ITowersDefenseRepository _repo;

        private readonly IMapper _mapper;

        public PlayersController(ITowersDefenseRepository repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayer(int id)
        {
             Player player = await _repo.GetPlayer(id);
            PlayerDto playerToReturn = _mapper.Map<PlayerDto>(player);
            
            return Ok(playerToReturn);
        }
    }
}
