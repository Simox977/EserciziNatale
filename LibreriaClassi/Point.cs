﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public partial class Point
    {
        partial void InitializePartial()
        {
            PointId = new Guid();
        }
    }
}
