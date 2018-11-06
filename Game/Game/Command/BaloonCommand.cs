using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;
using Game.Helpers.Enums;

namespace Game.Command
{
    class BaloonCommand : ICommand
    {
        private BaloonFactory _factory;
        private BaloonTypes _baloonType;
        private DebugLogSingleton _singleton;

        public BaloonCommand(BaloonFactory factory, BaloonTypes baloonType)
        {
            this._factory = factory;
            this._baloonType = baloonType;
            this._singleton = DebugLogSingleton.GetInstance();
            this._singleton.Log<BaloonCommand>("Command", "Initializing baloon command");
        }

        public dynamic Execute()
        {
            this._singleton.Log<BaloonCommand>("Command", "Executing baloon command.");
            return _factory.CreateNew(_baloonType);
        }
    }
}
