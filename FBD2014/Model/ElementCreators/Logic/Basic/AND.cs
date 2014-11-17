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
           this.discretInputs = new List<string> { "X[1]","X[2]"};
         
           this.discreteOutputs = new List<string> { "Y" };
         
     
           this.type = "AND";
           this.rusname = "И";
       }
    }
}
