﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molotkoff.FPS
{
    public interface IBulletViewFactory
    {
        IBulletViewSetup Create();
    }
}