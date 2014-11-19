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
    public partial class OutputView : UserControl
    {
        public OutputModel om;
        public OutputView()
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
            if (om.block.parentBlock.bv.innerDiagram.netcreating)
            {
                if (om.block.parentBlock.bv.innerDiagram.creatednetslave.iv.label1.ForeColor.Equals(this.label1.ForeColor))
                {
                    om.block.parentBlock.bv.innerDiagram.netcreating = false;
                    NetModel net = new NetModel(this.om, om.block.parentBlock.bv.innerDiagram.creatednetslave, this.om.block.parentBlock);
                    net.color = this.label1.ForeColor;
                    net.master.innernetList.Add(net);
                    net.slave.innernet = net;
                    net.Redrav();
                }
            }
            else
            {
                om.block.parentBlock.bv.innerDiagram.netcreating = true;
                om.block.parentBlock.bv.innerDiagram.netcolor = label1.ForeColor;
                om.block.parentBlock.bv.innerDiagram.creatednetfirst = new Point((int)om.block.Left + om.block.bv.Width, (int)om.block.Top + this.Top + 10);
                om.block.parentBlock.bv.innerDiagram.rightnettipe = false;
                om.block.parentBlock.bv.innerDiagram.creatednetmaster = this.om;
            }
        }
    }
}
