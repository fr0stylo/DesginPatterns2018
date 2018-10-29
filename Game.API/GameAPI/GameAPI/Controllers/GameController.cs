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
    public class GameController : ControllerBase
    {
        private Game _game;

        private Player _player1;
        private Player _player2;
        private Tower _tower1;
        private Tower _tower2;
        private Baloon _baloon1;
        private Baloon _baloon2;
        private Baloon _baloon3;

        [HttpPost("new/{gameId}")]
        public async Task<IActionResult> CreateGame(int gameId)
        {
            this._game = new Game();
            this._game.SetGameId(gameId);

            this._player1 = new Player(1, gameId);
            this._player2 = new Player(2, gameId);

            this._tower1 = new Tower(1, gameId);
            this._tower2 = new Tower(2, gameId);

            this._baloon1 = new Baloon(1, gameId);
            this._baloon2 = new Baloon(2, gameId);
            this._baloon3 = new Baloon(3, gameId);

            this._game.AttachPlayer(this._player1);
            this._game.AttachPlayer(this._player2);

            this._game.AttachTower(this._tower1);
            this._game.AttachTower(this._tower2);

            this._game.AttachBaloons(this._baloon1);
            this._game.AttachBaloons(this._baloon2);
            this._game.AttachBaloons(this._baloon3);
        }
       
       [HttpGet("{gameId}")]
       public async Task<IActionResult> IndexGame(int gameId)
       {

       }

    }
}
