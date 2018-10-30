using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.FactoryPattern;
using Game.Helpers.Enums;

namespace Game.BuilderPattern.Waves
{
    public class FirstWave : WaveBuilder
    {
        public override void BuildNumber() {
            this._wave.Number = 1;
        }

        public override void BuildSpacing() {
            _wave.Spacing = 1;
           base.BuildSpacing();
        }

        public override void BuildWave() {
            var factory = new BaloonFactory(true);
            for (var i = 0; i < 10; i++)
            {
                this._wave.Baloons.Add(factory.CreateBaloon(BaloonTypes.Weak));
            }
        }

        public override WaveBuilder NextBuilder() {
            return new SecondWave();
        }
    }
}
