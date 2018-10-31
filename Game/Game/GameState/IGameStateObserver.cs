using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameState
{
    public interface IGameStateObserver
    {
        void SetInConstructionMode(bool value);
    }
}
