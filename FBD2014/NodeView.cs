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
using System.Drawing;

namespace FBD2014
{
    public partial class NodeView : UserControl
    {
       public NetModel net;
        public NodeView(Point start, Point end, NetModel net)
        {
            InitializeComponent();
            this.net = net;
            this.BackColor = net.color;
            if (start.Y == end.Y)
            {
                if (start.X < end.X)
                {
                    this.Top = start.Y;
                    this.Left = start.X;
                }
                if (start.X >= end.X)
                {
                    this.Top = start.Y;
                    this.Left = end.X;
                }
                this.Height = 1;
                this.Width = Math.Abs(end.X - start.X);
            }

            if (start.X == end.X)
            {
                if (start.Y <= end.Y)
                {
                    this.Top = start.Y;
                    this.Left = start.X;
                }
                if (start.Y > end.Y)
                {
                    this.Top = end.Y;
                    this.Left = start.X;
                }
                this.Width = 1;
                this.Height = Math.Abs(end.Y - start.Y);
            }
            net.block.bv.innerDiagram.Controls.Add(this);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            net.RemoveNet();
        }
    }
}
