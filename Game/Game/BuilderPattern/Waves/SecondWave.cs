using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;
using Game.Helpers.Enums;

namespace Game.BuilderPattern.Waves
{
    class SecondWave : WaveBuilder
    {
        public override void BuildNumber() {
            
        }

        public override void BuildSpacing() {
            _wave.Spacing = 2;
            base.BuildSpacing();
        }

        public override void BuildWave() {
            var factory = new BaloonFactory(true);
            for (var i = 0; i < 10; i++)
            {
                factory.CreateBaloon(BaloonTypes.Weak);
            }
            for (var i = 0; i < 10; i++)
            {
                factory.CreateBaloon(BaloonTypes.Intermediate);
            }
            this._wave.Baloons = factory.Baloons();
        }

        public override WaveBuilder NextBuilder() {
            return new FirstWave();
        }
    }
}
