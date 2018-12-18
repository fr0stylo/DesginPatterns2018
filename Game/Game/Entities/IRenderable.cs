﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.VisitorPattern;

namespace Game.Entities
{
    public interface IRenderable: IVisitable {
        bool IsDisposed();
    }
}
