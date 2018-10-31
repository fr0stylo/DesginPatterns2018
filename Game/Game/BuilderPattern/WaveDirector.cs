using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BuilderPattern
{
    public class WaveDirector {
        private WaveBuilder _builder;

        public void SetBuilder(WaveBuilder builder) {
            _builder = builder;
        }

        public Wave GetWave => _builder.GetWave;

        public void BuildWave() {
            _builder.CreateNewWave();
            _builder.BuildWave();
            _builder.BuildNumber();
            _builder.BuildSpacing();
        }

        public void NextWave() {
            SetBuilder(_builder.NextBuilder());
        }
    }
}
