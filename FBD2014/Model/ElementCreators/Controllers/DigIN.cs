using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model.ElementCreators.Controllers
{
    class DigIN : ElementBasic
    {
        public DigIN()
        {
            this.type = "DigIN";
            this.rustype = "Цифр.вх.";
        }
    }
}
