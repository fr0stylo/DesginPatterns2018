using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;
using System.Drawing;
using Game.Helpers.Enums;

namespace Game.Command
{
    class TowerCommand : ICommand
    {
        private TowerFactory _factory;
        private Point _location;
        private TowerTypes _towerType;
        private DebugLogSingleton _singleton;

        public TowerCommand(TowerFactory factory, Point location, TowerTypes towerType)
        {
            this._factory = factory;
            this._location = location;
            this._towerType = towerType;
            this._singleton = DebugLogSingleton.GetInstance();
            this._singleton.Log<TowerCommand>("Command", "Initializing tower command");
        }

        public dynamic Execute()
        {
            this._singleton.Log<TowerCommand>("Command", "Executing tower command.");
            return _factory.CreateNew(_towerType, _location);
        }
    }
}
