using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FBD2014.Model.ElementCreators
{
    class ElementBasic
    {
      public List<string> discretInputs;
      public List<string> analogInputs;
      public List<string> digitalInputs;
      public List<string> discreteOutputs;
      public List<string> analogOutputs;
      public List<string> digitalOutputs;
      public string type;
      public string number;
      public string rusname; 
        public void createElement()
        {
            BlockModel bm = new BlockModel();
            BlockView bv = new BlockView();
            bm.type = type;
            foreach (string item in discretInputs)
            {
                InputModel im = new InputModel();
                im.connectedOutput = null;
                im.constantValueB = false;
                im.constantValueF = 0F;
                im.constantValueI = 0;
                im.grup = "";
                im.inputSourceType = InputSourceTypes.Connectable;
                im.inputType = InputTypes.Discret;
                im.max = 0;
                im.min = 0;
                im.name = "DI" + (discretInputs.IndexOf(item) + 1).ToString();
                im.rusname = item;
                bm.inputList.Add(im);
                InputView iv = new InputView();
                iv.Text = im.rusname;
                iv.ForeColor = Color.Blue;
                bv.Controls.Add(iv);
                iv.Top = 20 + 5 * discretInputs.IndexOf(item);
            }
            foreach (string item in analogInputs)
            {
                InputModel im = new InputModel();
                im.connectedOutput = null;
                im.constantValueB = false;
                im.constantValueF = 0F;
                im.constantValueI = 0;
                im.grup = "";
                im.inputSourceType = InputSourceTypes.Connectable;
                im.inputType = InputTypes.Analog;
                im.max = 0;
                im.min = 0;
                im.name = "AI" + (analogInputs.IndexOf(item) + 1).ToString();
                im.rusname = item;
                bm.inputList.Add(im);
                InputView iv = new InputView();
                iv.Text = im.rusname;
                iv.ForeColor = Color.Red;
                bv.Controls.Add(iv);
                iv.Top = 20 + 5 * discretInputs.Count;
                
            }
            foreach (string item in digitalInputs)
            {
                InputModel im = new InputModel();
                im.connectedOutput = null;
                im.constantValueB = false;
                im.constantValueF = 0F;
                im.constantValueI = 0;
                im.grup = "";
                im.inputSourceType = InputSourceTypes.Connectable;
                im.inputType = InputTypes.Digital;
                im.max = 0;
                im.min = 0;
                im.name = "DigI" + (analogInputs.IndexOf(item) + 1).ToString();
                im.rusname = item;
                bm.inputList.Add(im);
                InputView iv = new InputView();
                iv.Text = im.rusname;
                iv.ForeColor = Color.Green;
                bv.Controls.Add(iv);
                iv.Top = 20 + 5 * discretInputs.Count+5*analogInputs.Count;
            }
        }
    }
}
