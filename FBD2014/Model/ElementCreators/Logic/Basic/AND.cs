using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model.ElementCreators.Logic.Basic
{
   public class AND:ElementBasic
    {
       public AND()
       {
           this.discretInputs = new List<string> { "X[1]","X[2]","X[3]"};
           this.analogInputs = new List<string> { "X[1]", "X[2]", "X[3]" };
           this.type = "AND";
           this.rusname = "И";
       }
    }
}
