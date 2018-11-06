using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.BuilderPattern
{
    public class WaveDirector {
        private WaveBuilder _builder;
        private DebugLogSingleton _singleton;

        public WaveDirector() {
            _singleton = DebugLogSingleton.GetInstance();
        }

        public void SetBuilder(WaveBuilder builder) {
            _singleton.Log<WaveDirector>("Setting builder");
            _builder = builder;
        }

        public Wave GetWave => _builder.GetWave;

        public void BuildWave() {
            _singleton.Log<WaveDirector>("Creating Wave");
            _builder.CreateNewWave();
            _singleton.Log<WaveDirector>("Building Wave");
            _builder.BuildWave();
            _singleton.Log<WaveDirector>("Build Number");
            _builder.BuildNumber();
            _singleton.Log<WaveDirector>("Build Spacing");
            _builder.BuildSpacing();
        }

        public void NextWave() {
            _singleton.Log<WaveDirector>("Set Next builder");
            SetBuilder(_builder.NextBuilder());
        }
    }
}
