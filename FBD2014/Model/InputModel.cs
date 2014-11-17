using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model
{
   public class InputModel
    {
        public InputTypes inputType;
        public OutputModel connectedOutput;
        public InputSourceTypes inputSourceType;
        public float constantValueF;
        public int constantValueI;
        public bool constantValueB;
        public string okno;
        public string grup;
        public string raspGroup;
        public int min;
        public int max;
        public string name;
        public string rusname;
    }
}
