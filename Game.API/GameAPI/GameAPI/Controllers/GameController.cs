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
        IList<Game> game = new List<Game>() {
            new Game()
            {
                GameId = 1,
                Players = {
                    new Player(1, 1),
                    new Player(2, 1),
                },
                Towers = {
                    new Tower(1, 1),
                    new Tower(2, 1),
                },
                Baloons = {
                    new Baloon(1, 1),
                    new Baloon(2, 1),
                    new Baloon(3, 1),
                },
            }
        };

        // Get game/new/1
        [HttpGet("new/{gameId}")]
        public ActionResult<string> CreateGame(int gameId)
        {
            return "In futer here can be created new game";
        }

        // GET game/1
        [HttpGet("{gameid}")]
        public Game indexgame(int gameid)
        {
            var _game = this.game.FirstOrDefault(e => e.GameId == gameid);
            return _game;
        }

        // GET game/1/tower/1/hitBaloon/1
        [HttpGet("{gameId}/tower/{towerId}/hitBaloon/{baloonId}")]
        public Game HitBaloonAction(int gameId, int towerId, int baloonId)
        {
            var _game = this.game.FirstOrDefault(e => e.GameId == gameId);

            _game.ChangeBaloonHealth(baloonId, 30);

            return _game;
        }

        // GET game/1/player/1/addMoney/100
        [HttpGet("{gameId}/player/{playerId}/addMoney/{count}")]
        public Game AddMoneyToPlayerAction(int gameId, int playerId, int count)
        {
            var _game = this.game.FirstOrDefault(e => e.GameId == gameId);

            _game.AddMoneyTo(playerId, count);

            return _game;
        }
    }
}
