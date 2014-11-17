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
            this.discretInputs = new List<string> { "DI1", "DI2", "DI3", "DI4", "DI5", "DI6", "DI7", "DI8" };
            this.analogInputs = new List<string> { "AI1", "AI2", "AI3", "AI4", "AI5", "AI6", "AI7", "AI8" };
            this.discreteOutputs = new List<string> { "DO1", "DO2", "DO3", "DO4", "DO5", "DO6", "DO7", "DO8", "DO9", "DO10" };
            this.analogOutputs = new List<string> { "AO1", "AO2", "AO3", "AO4" };
            this.digitalInputs = new List<string> { "Циф" };
            this.digitalOutputs = new List<string> { "Циф" };
            this.type = "Controller";
            this.isAtom = false;
        }
    }
}
