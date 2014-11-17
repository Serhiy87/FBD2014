using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model
{
   public class BlockModel
    {
        public List<InputModel> inputList;
        public List<OutputModel> outputList;
        public bool isAtom;
        public List<BlockModel> innerBlocks;
        public double Top;
        public double Left;
        public string type;
        public string name;
        public string rustype;
        public string rusfullname;

    }
}
