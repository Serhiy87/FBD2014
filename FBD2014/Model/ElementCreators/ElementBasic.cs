using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FBD2014.ViewModel;
using System.Windows.Forms;
using FBD2014.Model.ElementCreators.Controllers;

namespace FBD2014.Model.ElementCreators
{
  public class ElementBasic
  {
      ViewModel.ViewModel vm = new ViewModel.ViewModel();
      public List<string> discretInputs=new List<string>();
      public List<string> analogInputs=new List<string>();
      public List<string> digitalInputs = new List<string>();
      public List<string> discreteOutputs = new List<string>();
      public List<string> analogOutputs = new List<string>();
      public List<string> digitalOutputs = new List<string>();
      public List<BlockModel> innerBlocks = new List<BlockModel>();
      public string type;
      public string number;
      public string rusname;
      public bool isAtom = true;
      public void customizeProperty()
      {}
        public BlockModel createElement(DiagramForm df)
        {
            BlockModel bm = new BlockModel();
            bm.innerBlocks = new List<BlockModel>();
            bm.inputList = new List<InputModel>();
            bm.outputList = new List<OutputModel>();
            BlockView bv = new BlockView();
            bm.type = type;
            if (!this.isAtom)
            {
                bv.innerDiagram = new DiagramForm();
                bv.innerDiagram.MdiParent =ViewModel.ViewModel.mf;
              
                bv.innerDiagram.Size = bv.innerDiagram.MaximumSize;
                bv.innerDiagram.WindowState= FormWindowState.Maximized;
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
                iv.Top = 20+15*analogInputs.IndexOf(item);
                if (!this.isAtom)
                {
                    AIN ain = new AIN();
                    ain.analogOutputs.Add(item);
                    BlockModel blm = ain.createElement(bv.innerDiagram);
                    blm.bv.Height = 15;
                    blm.bv.Width = 50;
                    blm.bv.Top = 20 + 20 * analogInputs.IndexOf(item);
                    blm.bv.Controls[blm.bv.Controls.Count - 1].Top = 0;
                    blm.bv.Controls[blm.bv.Controls.Count - 1].Left = 15;
                    blm.bv.labelName.Visible = false;
                    bm.innerBlocks = new List<BlockModel>();
                    bm.innerBlocks.Add(blm);
                }
                
            }
            if (discretInputs.Count > 0)
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
                    iv.Top = 20 + 15 * discretInputs.IndexOf(item)+15*analogInputs.Count;
                    if (!this.isAtom)
                    {
                        DIN ain = new DIN();
                        ain.discreteOutputs.Add(item);
                        BlockModel blm = ain.createElement(bv.innerDiagram);
                        blm.bv.Height = 15;
                        blm.bv.Width = 50;
                        blm.bv.Top = 20 + 20 *discretInputs.IndexOf(item) + 20 * analogInputs.Count;
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Top = 0;
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Left = 15;
                        blm.bv.labelName.Visible = false;
                      
                        bm.innerBlocks.Add(blm);
                    }
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
                iv.Top = 20 + 15 * discretInputs.Count + 15 * analogInputs.Count + 15 * digitalInputs.IndexOf(item);
                if (!this.isAtom)
                {
                    DigIN ain = new DigIN();
                    ain.digitalOutputs.Add(item);
                    BlockModel blm = ain.createElement(bv.innerDiagram);
                    blm.bv.Height = 15;
                    blm.bv.Width = 50;
                    blm.bv.Top = 20 + 20 * digitalInputs.IndexOf(item) + 20 * analogInputs.Count+20*discretInputs.Count;
                    blm.bv.Controls[blm.bv.Controls.Count - 1].Top = 0;
                    blm.bv.Controls[blm.bv.Controls.Count - 1].Left = 15;
                    blm.bv.labelName.Visible = false;
                   
                    bm.innerBlocks.Add(blm);
                }
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
                    ov.Top = 20 + 15 * analogOutputs.IndexOf(item) ;
                    ov.Left = 65;
                    if (!this.isAtom)
                    {
                        AOUT ain = new AOUT();
                        ain.analogInputs.Add(item);
                        BlockModel blm = ain.createElement(bv.innerDiagram);
                        blm.bv.Height = 15;
                        blm.bv.Width = 50;
                        blm.bv.Top = 20  + 20 * analogOutputs.IndexOf(item);
                         blm.bv.Left =980;
                        
                        bv.innerDiagram.label1.Text = bv.innerDiagram.Width.ToString();
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Top = 0;
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Left = 0;
                        blm.bv.labelName.Visible = false;
                        
                        bm.innerBlocks.Add(blm);
                    }
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
                    ov.Top = 20 + 15 * discreteOutputs.IndexOf(item)+15 * analogOutputs.Count;
                    ov.Left = 65;
                    if (!this.isAtom)
                    {
                        DOUT ain = new DOUT();
                        ain.discretInputs.Add(item);
                        BlockModel blm = ain.createElement(bv.innerDiagram);
                        blm.bv.Height = 15;
                        blm.bv.Width = 50;
                        blm.bv.Top = 20 + 20 * analogOutputs.Count+20*discreteOutputs.IndexOf(item);
                        blm.bv.Left = 980;

                        bv.innerDiagram.label1.Text = bv.innerDiagram.Width.ToString();
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Top = 0;
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Left = 0;
                        blm.bv.labelName.Visible = false;

                        bm.innerBlocks.Add(blm);
                    }
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
                    ov.Left = 65;
                    if (!this.isAtom)
                    {
                        DigOUT ain = new DigOUT();
                        ain.digitalInputs.Add(item);
                        BlockModel blm = ain.createElement(bv.innerDiagram);
                        blm.bv.Height = 15;
                        blm.bv.Width = 50;
                        blm.bv.Top = 20 + 20 * analogOutputs.Count + 20 * discreteOutputs.Count+20*digitalOutputs.IndexOf(item);
                        blm.bv.Left = 980;

                        bv.innerDiagram.label1.Text = bv.innerDiagram.Width.ToString();
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Top = 0;
                        blm.bv.Controls[blm.bv.Controls.Count - 1].Left = 0;
                        blm.bv.labelName.Visible = false;

                        bm.innerBlocks.Add(blm);
                    }
                }
            if ((discretInputs.Count + analogInputs.Count + digitalInputs.Count) > (discreteOutputs.Count + analogOutputs.Count + digitalOutputs.Count))
            {
                bv.Height = (discretInputs.Count + analogInputs.Count + digitalInputs.Count)*15+20;
            }
            else
            {
                bv.Height = (discreteOutputs.Count + analogOutputs.Count + digitalOutputs.Count) * 15 + 20;
            } 
            bm.bv = bv;
            bv.bm = bm;
            df.Controls.Add(bv);
           
            return bm;
           
         
        }
    }
}
