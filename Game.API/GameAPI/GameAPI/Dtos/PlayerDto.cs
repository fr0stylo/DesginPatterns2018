using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Dtos
{
    public class PlayerDto
    {

            public int PlayerId { get; set; }

            public string Name { get; set; }

            public int MoneyPoints { get; set; }

            public int HealthPoints { get; set; }

            public int GameId { get; set; }
    }
}
