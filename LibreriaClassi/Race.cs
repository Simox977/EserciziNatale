﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassi
{
    public partial class Race
    {
        partial void InitializePartial()
        {
            RaceId = new Guid();
        }
    }
}
