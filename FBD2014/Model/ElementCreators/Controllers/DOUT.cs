using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model.ElementCreators.Controllers
{
    class DOUT : ElementBasic
    {
        public DOUT()
        {
            this.type = "DOUT";
            this.rustype = "Дискр.вых.";
        }
    }
}
