using Game.Entities;
using Game.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Helpers.Enums;
using System.Collections;

namespace Game.FactoryPattern
{
    public class BaloonFactory
    {
        private bool isPlayer1Factory;
        private DebugLogSingleton _singleton;
        List<IBaloon> createdBaloons;

        public BaloonFactory(bool isPlayer1Factory)
        {
            this.isPlayer1Factory = isPlayer1Factory;
            _singleton = DebugLogSingleton.GetInstance();
            createdBaloons = new List<IBaloon>();
        }

        public IBaloon CreateNew(BaloonTypes baloonType)
        {
            _singleton.Log<BaloonFactory>("Factory", "Creating baloon");

            IBaloon baloon = null;
            if ( null != createdBaloons.Where(x => x.GetBaloonType() == baloonType && x.GetIsDead()).FirstOrDefault())
            {
                baloon = createdBaloons.Where(x => x.GetBaloonType() == baloonType && x.GetIsDead()).First();
                baloon.SetDefaultValues();
                _singleton.Log<BaloonFactory>("Flyweight", "Objects count: "  + createdBaloons.Count.ToString());

            }
            else
            {
                switch (baloonType)
                {
                    case BaloonTypes.Weak:
                         baloon = new  WeakBaloon(isPlayer1Factory);
                         createdBaloons.Add(baloon);
                         return baloon;
                    case BaloonTypes.Intermediate:
                         baloon = new IntermediateBaloon(isPlayer1Factory);
                         createdBaloons.Add(baloon);
                        return baloon;
                    case BaloonTypes.Powerful:
                         baloon = new PowerfulBaloon(isPlayer1Factory);
                         createdBaloons.Add(baloon);
                         return baloon;
                    default:
                        return null;
                }
            }
            return null;
        }
    }
}
