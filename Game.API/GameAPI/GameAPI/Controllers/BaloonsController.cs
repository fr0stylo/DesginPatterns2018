using GameAPI.Data;
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
            //Baloon baloon = new Baloon();
            //baloon.AttackPlayer1 = true;
            //baloon.AttackPlayer2 = false;
            //baloon.BaloonId = 1;
            //baloon.GameId = 1;
            //baloon.Type = "WeakBaloon";
            return Ok(baloon);
        }
        [HttpPost]
        public async Task<IActionResult> InsertBaloon(Baloon baloon, int gameId)
        {
            var game = await _repo.GetGame(gameId);
            game.Baloons.Add(baloon);

            if (await _repo.SaveAll())
                return Ok();

            return BadRequest("You made a bad request mate.");
        }
    }
}
