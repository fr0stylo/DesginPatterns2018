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
            WeakBaloon weakBaloon = (WeakBaloon)factory.CreateBaloon(BaloonTypes.Weak);
            IntermediateBaloon intermediateBaloon = (IntermediateBaloon)factory.CreateBaloon(BaloonTypes.Intermediate);

            if (GameStateSingleton.GetInstance().GetAllowAddPlayer1Baloons())
            {
                for (var i = 0; i < 10; i++)
                {
                    this._wave.Baloons.Add((IBaloon)weakBaloon.Clone());
                }
                for (var i = 0; i < 10; i++)
                {
                    this._wave.Baloons.Add((IBaloon)intermediateBaloon.Clone());
                }
            }
        }

        public override WaveBuilder NextBuilder() {
            return new FirstWave();
        }
    }
}
