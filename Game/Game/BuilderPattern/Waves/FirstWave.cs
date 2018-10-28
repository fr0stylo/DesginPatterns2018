using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            for (var i = 0; i < 10; i ++) {
                factory.CreateBaloon(BaloonTypes.Weak);
            }

            this._wave.Baloons = factory.Baloons();
        }

        public override WaveBuilder NextBuilder() {
            return new SecondWave();
        }
    }
}
