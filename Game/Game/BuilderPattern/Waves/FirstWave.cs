using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.FactoryPattern;
using Game.Helpers.Enums;
using Game.PrototypePattern;

namespace Game.BuilderPattern.Waves
{
    public class FirstWave : WaveBuilder
    {
        private DebugLogSingleton _singleton;

        public FirstWave()
        {
            _singleton = DebugLogSingleton.GetInstance();
        }
        public override void BuildNumber() {
            _wave.Number = 1;
        }

        public override void BuildSpacing() {
            _wave.Spacing = 1;
           base.BuildSpacing();
        }

        public override void BuildWave() {
            var factory = new BaloonFactory(true);
            IBaloon weakBaloon = factory.CreateNew(BaloonTypes.Weak);
            for (var i = 0; i < 10; i++)
            {
                _wave.Baloons.Add((IBaloon)weakBaloon.Clone());
                _singleton.Log<IPrototype>("Prototype", "Cloning baloon while creating wave");

            }
        }

        public override WaveBuilder NextBuilder() {
            return new SecondWave();
        }
    }
}
