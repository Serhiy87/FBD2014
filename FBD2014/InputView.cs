using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBD2014.Model;

namespace FBD2014
{
    public partial class InputView : UserControl
    {
        public InputModel im;
        public InputView()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (im.block.parentBlock.bv.innerDiagram.netcreating)
            {
                if (im.block.parentBlock.bv.innerDiagram.rightnettipe == false)
                {
                    if(im.block.parentBlock.bv.innerDiagram.creatednetmaster.ov.label1.ForeColor.Equals(this.label1.ForeColor))
                    {
                        if (im.innernet == null)
                        {
                            im.block.parentBlock.bv.innerDiagram.netcreating = false;
                            NetModel net = new NetModel(im.block.parentBlock.bv.innerDiagram.creatednetmaster, this.im, im.block.parentBlock);
                            net.color = this.label1.ForeColor;
                            net.master.innernetList.Add(net);
                            net.slave.innernet = net;
                            net.Redrav();
                        }
                    }
                }
            }
            else
            {
                if (im.innernet == null)
                {
                    im.block.parentBlock.bv.innerDiagram.netcreating = true;
                    im.block.parentBlock.bv.innerDiagram.netcolor = label1.ForeColor;
                    im.block.parentBlock.bv.innerDiagram.creatednetfirst = new Point((int)im.block.Left, (int)im.block.Top + this.Top + 10);
                    im.block.parentBlock.bv.innerDiagram.rightnettipe = true;
                    im.block.parentBlock.bv.innerDiagram.creatednetslave = this.im;
                }
            }
        }

       
    }
}
