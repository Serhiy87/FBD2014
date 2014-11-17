using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBD2014.Model;

namespace FBD2014.Model.ElementCreators.Controllers
{
    class ArduinoMega : ElementBasic
    {
        public ArduinoMega()
        {
            this.discretInputs = new List<string> { "DI1", "DI2","DI3","DI4","DI5","DI6" };

            this.discreteOutputs = new List<string> { "Y" };
        }
    }
}
