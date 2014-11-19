using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model.ElementCreators
{
   public class HardBlockPrimitive:ElementBasic
    {
       public HardBlockPrimitive()
        {
            this.isAtom = false;
            this.analogInputs = new List<string> { "AI1" };
            this.analogOutputs = new List<string> { "AO1" };
            this.rustype = "Сост.бл.";
        }
    }
}
