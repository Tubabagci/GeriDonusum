﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
     interface IDolabilen
     {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
     }
}
