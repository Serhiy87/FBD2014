using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBD2014.Model
{
  public  class OutputModel
    {
        public PinTypes outputType;
        public bool isInMenu;
        public string okno;
        public string grup;
        public string raspGroup;
        public string name;
        public string rusname;
        public BlockModel block;
        public OutputView ov;
        public List<NetModel> innernetList=new List<NetModel>();

    }
}
