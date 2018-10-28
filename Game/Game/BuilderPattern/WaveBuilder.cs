using System.Collections.Generic;
using Game.FactoryPattern;

namespace Game.BuilderPattern {
    public abstract class WaveBuilder {
        protected Wave _wave;

        internal Wave GetWave => _wave;

        public void CreateNewWave() {
            _wave = new Wave();
        }

        public abstract void BuildNumber();
        public abstract void BuildSpacing();
        public abstract void BuildWave();
    }
}