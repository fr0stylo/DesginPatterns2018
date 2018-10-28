﻿using System;
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

        public Wave GetVave => _builder.GetWave;

        public void BuildWave() {
            _builder.CreateNewWave();
            _builder.BuildNumber();
            _builder.BuildSpacing();
            _builder.BuildWave();
        }
    }
}
