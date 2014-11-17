using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FBD2014.ViewModel;
using System.Windows.Forms;

namespace FBD2014.Model.ElementCreators
{
  public class ElementBasic
    {
      public List<string> discretInputs=new List<string>();
      public List<string> analogInputs=new List<string>();
      public List<string> digitalInputs = new List<string>();
      public List<string> discreteOutputs = new List<string>();
      public List<string> analogOutputs = new List<string>();
      public List<string> digitalOutputs = new List<string>();
      public string type;
      public string number;
      public string rusname; 
        public void createElement(DiagramForm df)
        {
            BlockModel bm = new BlockModel();
            bm.inputList = new List<InputModel>();
            bm.outputList = new List<OutputModel>();
            BlockView bv = new BlockView();
            bm.type = type;
            if(discretInputs.Count>0)
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
                bv.Controls.Add(iv);
                iv.im = im;
                iv.label1.Text = im.rusname;
                iv.ForeColor = Color.Blue;
                iv.Top = 20 + 15* discretInputs.IndexOf(item);
                
                df.label1.Text = bv.Controls.ToString(); 
             
                
            }
            if(analogInputs.Count>0)
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
                iv.label1.Text = im.rusname;
                iv.ForeColor = Color.Red;
                bv.Controls.Add(iv);
                iv.Top = 20 + 20 * discretInputs.Count;
                
            }
            if(digitalInputs.Count>0)
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
                iv.label1.Text = im.rusname;
                iv.ForeColor = Color.Green;
                bv.Controls.Add(iv);
                iv.Top = 20 + 5 * discretInputs.Count+5*analogInputs.Count;
            }
            df.Controls.Add(bv);
        }
    }
}
