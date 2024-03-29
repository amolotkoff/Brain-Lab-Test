﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public interface IBulletPresenter : IEnable, IDisable, IDisposable
    {
        public IBulletModel Model { get; }
    }
}