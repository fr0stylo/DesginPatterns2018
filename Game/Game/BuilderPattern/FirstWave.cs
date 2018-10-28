using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.FactoryPattern;
using Game.Helpers.Enums;

namespace Game.BuilderPattern
{
    public class FirstWave : WaveBuilder
    {
        public override void BuildNumber() {
            this._wave.Number = 1;
        }

        public override void BuildSpacing() {
            this._wave.Spacing = 0;
        }

        public override void BuildWave() {
            var factory = new BaloonFactory(true);
            for (var i = 0; i < 10; i ++) {
                factory.CreateBaloon(BaloonTypes.Weak);
            }

            this._wave.Baloons = factory.Baloons();
        }
    }
}
