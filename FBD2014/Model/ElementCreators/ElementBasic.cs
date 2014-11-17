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
                im.inputType = PinTypes.Discret;
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
                im.inputType = PinTypes.Analog;
                im.max = 0;
                im.min = 0;
                im.name = "AI" + (analogInputs.IndexOf(item) + 1).ToString();
                im.rusname = item;
                bm.inputList.Add(im);
                InputView iv = new InputView();
                iv.label1.Text = im.rusname;
                iv.ForeColor = Color.Red;
                bv.Controls.Add(iv);
                iv.Top = 20 + 15 * discretInputs.Count+15*analogInputs.IndexOf(item);
                
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
                im.inputType = PinTypes.Digital;
                im.max = 0;
                im.min = 0;
                im.name = "DigI" + (analogInputs.IndexOf(item) + 1).ToString();
                im.rusname = item;
                bm.inputList.Add(im);
                InputView iv = new InputView();
                iv.label1.Text = im.rusname;
                iv.ForeColor = Color.Green;
                bv.Controls.Add(iv);
                iv.Top = 20 + 15 * discretInputs.Count+15*analogInputs.Count+15*analogInputs.IndexOf(item);
            }
            if (discreteOutputs.Count > 0)
                foreach (string item in discreteOutputs)
                {
                    OutputModel om = new OutputModel();
                                 
                    om.grup = "";
                    om.okno = "";
                    om.outputType = PinTypes.Discret;
                    om.raspGroup = "";
                    om.name = "DO" + (discreteOutputs.IndexOf(item) + 1).ToString();
                    om.rusname = item;
                    bm.outputList.Add(om);
                    OutputView ov = new OutputView();
                    bv.Controls.Add(ov);
                    ov.om = om;
                    ov.label1.Text = om.rusname;
                    ov.label1.TextAlign = ContentAlignment.BottomRight;
                    ov.ForeColor = Color.Blue;
                    ov.Top = 20 + 15 * discreteOutputs.IndexOf(item);
                    ov.Left = 75;
                    df.label1.Text = bv.Controls.ToString();
                }
            if (analogOutputs.Count > 0)
                foreach (string item in analogOutputs)
                {
                    OutputModel om = new OutputModel();

                    om.grup = "";
                    om.okno = "";
                    om.outputType = PinTypes.Analog;
                    om.raspGroup = "";
                    om.name = "AO" + (analogOutputs.IndexOf(item) + 1).ToString();
                    om.rusname = item;
                    bm.outputList.Add(om);
                    OutputView ov = new OutputView();
                    bv.Controls.Add(ov);
                    ov.om = om;
                    ov.label1.Text = om.rusname;
                    ov.label1.TextAlign = ContentAlignment.BottomRight;
                    ov.ForeColor = Color.Red;
                    ov.Top = 20 + 15 * analogOutputs.IndexOf(item) + 15 * discreteOutputs.Count;
                    ov.Left = 75;
                    df.label1.Text = bv.Controls.ToString();
                }
            if (digitalOutputs.Count > 0)
                foreach (string item in digitalOutputs)
                {
                    OutputModel om = new OutputModel();

                    om.grup = "";
                    om.okno = "";
                    om.outputType = PinTypes.Digital;
                    om.raspGroup = "";
                    om.name = "DigO" + (digitalOutputs.IndexOf(item) + 1).ToString();
                    om.rusname = item;
                    bm.outputList.Add(om);
                    OutputView ov = new OutputView();
                    bv.Controls.Add(ov);
                    ov.om = om;
                    ov.label1.Text = om.rusname;
                    ov.label1.TextAlign = ContentAlignment.BottomRight;
                    ov.ForeColor = Color.Green;
                    ov.Top = 20 + 15 * digitalOutputs.IndexOf(item)+15 * discreteOutputs.Count+15*analogOutputs.Count;
                    ov.Left = 75;
                    df.label1.Text = bv.Controls.ToString();
                }
            if ((discretInputs.Count + analogInputs.Count + digitalInputs.Count) > (discreteOutputs.Count + analogOutputs.Count + digitalOutputs.Count))
            {
                bv.Height = (discretInputs.Count + analogInputs.Count + digitalInputs.Count)*15+20;
            }
            else
            {
                bv.Height = (discreteOutputs.Count + analogOutputs.Count + digitalOutputs.Count) * 15 + 20;
            }
            df.Controls.Add(bv);
        }
    }
}
