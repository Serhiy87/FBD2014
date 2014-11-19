using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FBD2014.Model
{
   public class BlockModel
   {
       [XmlElement("inputList")]
        public List<InputModel> inputList;
       [XmlElement("outputList")]
        public List<OutputModel> outputList;
        public bool isAtom=true;
       [XmlElement("innerBlocks")]
        public List<BlockModel> innerBlocks;
        public double Top = 0;
        public double Left =0;
        public string type = "";
        public string name = "";
        public string rustype = "";
        public string rusfullname="";
       [XmlElement("bv")]
        public BlockView bv;
       [XmlElement("parentBlock")]
        public BlockModel parentBlock;
       public int number;
       public int priority;

    }
}
