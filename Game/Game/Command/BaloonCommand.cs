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

        public BaloonCommand(BaloonFactory factory, BaloonTypes baloonType)
        {
            this._factory = factory;
            this._baloonType = baloonType;
        }

        public dynamic Execute()
        {
            return _factory.CreateNew(_baloonType);
        }
    }
}
