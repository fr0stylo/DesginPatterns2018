using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BuilderPattern {
    public class WaveDirector {
        private WaveBuilder _builder;
        private DebugLogSingleton _singleton;

        public WaveDirector() {
            _singleton = DebugLogSingleton.GetInstance();
        }

        public void SetBuilder(WaveBuilder builder) {
            _singleton.Log<WaveDirector>("Builder", "Setting builder");
            _builder = builder;
        }

        public Wave GetWave => _builder.GetWave;

        public void BuildWave() {
            _singleton.Log<WaveDirector>("Builder", "Creating Wave");
            _builder.CreateNewWave();
            _singleton.Log<WaveDirector>("Builder", "Build Spacing");
            _builder.BuildSpacing();
            _singleton.Log<WaveDirector>("Builder", "Building Wave");
            _builder.BuildWave();
            _singleton.Log<WaveDirector>("Builder", "Build Number");
            _builder.BuildNumber();
        }

        public void NextWave() {
            _singleton.Log<WaveDirector>("Builder", "Set Next builder");
            SetBuilder(_builder.NextBuilder());
        }
    }
}