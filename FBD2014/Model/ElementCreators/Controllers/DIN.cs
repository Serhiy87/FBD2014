﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model.ElementCreators.Controllers
{
    class DIN:ElementBasic
    {
        public DIN()
        {
            this.type = "DIN";
            this.rustype = "Дискр.вх.";
        }
    }
}
