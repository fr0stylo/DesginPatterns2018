using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.Input
{
    public abstract class MouseSubject
    {
        private GameStateSingleton _gameState;

        public void Attach(GameStateSingleton observer)
        {
            _gameState = observer;
        }

        public void Detach()
        {
            _gameState = null;
        }

        public void ChangeGameStateBuildingMode(bool value)
        {
            _gameState.SetInConstructionMode(value);
        }
    }
}
