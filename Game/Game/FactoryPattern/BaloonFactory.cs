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
    class BaloonFactory
    {
        private bool isPlayer1Factory;
        private Baloon weakBaloon;
        private Baloon intermediateBaloon;
        private Baloon powerfulBaloon;

        public BaloonFactory(bool isPlayer1Factory)
        {
            this.isPlayer1Factory = isPlayer1Factory;
            weakBaloon = new WeakBaloon(isPlayer1Factory);
            intermediateBaloon = new IntermediateBaloon(isPlayer1Factory);
            powerfulBaloon = new PowerfulBaloon(isPlayer1Factory);
        }

        public IBaloon CreateBaloon(BaloonTypes baloonType)
        {
            switch (baloonType)
            {
                case BaloonTypes.Weak:
                    return weakBaloon.Clone();
                case BaloonTypes.Intermediate:
                    return intermediateBaloon.Clone();
                case BaloonTypes.Powerful:
                    return powerfulBaloon.Clone();
                default:
                    return null;

            }
        }
    }
}
