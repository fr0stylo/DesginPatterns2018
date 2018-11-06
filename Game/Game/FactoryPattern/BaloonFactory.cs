using Game.Entities;
using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Helpers.Enums;

namespace Game.FactoryPattern
{
    public class BaloonFactory
    {
        private bool isPlayer1Factory;
        private DebugLogSingleton _singleton;


        public BaloonFactory(bool isPlayer1Factory)
        {
            this.isPlayer1Factory = isPlayer1Factory;
            _singleton = DebugLogSingleton.GetInstance();
        }

        public IBaloon CreateNew(BaloonTypes baloonType)
        {
            _singleton.Log<BaloonFactory>("Factory", "Creating baloon");

            switch (baloonType)
            {
                case BaloonTypes.Weak:
                    return new WeakBaloon(isPlayer1Factory);
                case BaloonTypes.Intermediate:
                    return new IntermediateBaloon(isPlayer1Factory);
                case BaloonTypes.Powerful:
                    return new PowerfulBaloon(isPlayer1Factory);
                default:
                    return null;

            }
        }
    }
}
