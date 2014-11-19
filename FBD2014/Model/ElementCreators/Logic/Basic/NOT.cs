using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model.ElementCreators.Logic.Basic
{
    class NOT : ElementBasic
    {
        public NOT()
       {
           this.discretInputs = new List<string> { "X[1]"};
         
           this.discreteOutputs = new List<string> { "Y" };
         
     
           this.type = "NOT";
           this.rustype = "HE";
       }
    }
}
