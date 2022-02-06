﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public interface IHealthPresenter
    {
        public IHealthModel Model { get; }
        public IHealthView View { get; }
    }
}
