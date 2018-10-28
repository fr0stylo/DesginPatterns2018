using System.Collections.Generic;
using Game.FactoryPattern;

namespace Game.BuilderPattern {
    public abstract class WaveBuilder {
        protected Wave _wave;

        internal Wave GetWave => _wave;

        public void CreateNewWave() {
            _wave = new Wave();
            _wave.Baloons = new List<IBaloon>();
        }

        public virtual void BuildSpacing() {
            for (var i = 0; i < _wave.Baloons.Count; i++)
            {
                _wave.Baloons[i].SetReleaseSpacing(i * _wave.Spacing, 0);
            }
        }

        public abstract void BuildNumber();
        public abstract void BuildWave();
        public abstract WaveBuilder NextBuilder();
    }
}