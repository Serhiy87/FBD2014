using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FBD2014.Model
{
   public class NetModel
    {
        public BlockModel block;
        public Color color;
        public OutputModel master;
        public InputModel slave;
        public List<NodeView> nodelist;
        public NetModel(OutputModel master, InputModel slave, BlockModel block)
        {
            nodelist = new List<NodeView>();
            this.master = master;
            this.slave = slave;
            this.block = block;
           

            Point start = new Point(master.block.bv.Left + master.block.bv.Width, master.ov.Top + master.block.bv.Top + 10);
            Point finish = new Point(slave.block.bv.Left, slave.iv.Top + slave.block.bv.Top + 10);
            drawnet(start, finish);
            
            
        }

        public void drawnet(Point start, Point end)
        {


            foreach (NodeView item in nodelist)
            {
                this.block.bv.innerDiagram.Controls.Remove(item);
            }
            nodelist.Clear();
            if (start.X < end.X - 20)
            {
                int xdistance = end.X - start.X;
                int ydistance = end.Y - start.Y;
                // f.label3.Text = xdistance.ToString();
                //f.label4.Text = ydistance.ToString();
                nodelist.Add(new NodeView(start, new Point(start.X + 10, start.Y), this));
                nodelist.Add(new NodeView(new Point(start.X + 10, start.Y), new Point(start.X + 10 + ((xdistance - 20) / 2), start.Y), this));
                nodelist.Add(new NodeView(new Point(start.X + 10 + ((xdistance - 20) / 2), start.Y), new Point(start.X + 10 + ((xdistance - 20) / 2), start.Y + ydistance), this));
                nodelist.Add(new NodeView(new Point(start.X + 10 + ((xdistance - 20) / 2), start.Y + ydistance), new Point(start.X + 10 + (xdistance - 20), start.Y + ydistance), this));
                nodelist.Add(new NodeView(new Point(start.X + 10 + (xdistance - 20), start.Y + ydistance), end, this));
            }

            if (start.X >= end.X - 20)
            {
                int xdistance = end.X - start.X;
                int ydistance = end.Y - start.Y;
                // f.label3.Text = xdistance.ToString();
                //f.label4.Text = ydistance.ToString();
                nodelist.Add(new NodeView(start, new Point(start.X + 10, start.Y), this));
                nodelist.Add(new NodeView(new Point(start.X + 10, start.Y), new Point(start.X + 10, start.Y + ydistance / 2), this));
                nodelist.Add(new NodeView(new Point(start.X + 10, start.Y + ydistance / 2), new Point(start.X + 10 + ((xdistance - 20)), start.Y + ydistance / 2), this));
                nodelist.Add(new NodeView(new Point((start.X + 10 + xdistance - 20), start.Y + ydistance / 2), new Point(start.X + 10 + (xdistance - 20), start.Y + ydistance), this));
                nodelist.Add(new NodeView(new Point(start.X + 10 + (xdistance - 20), start.Y + ydistance), end, this));
            }
            this.block.bv.innerDiagram.Invalidate();
        }

        public void Redrav()
        {
            drawnet(new Point(master.block.bv.Left + master.block.bv.Width, master.ov.Top + master.block.bv.Top + 10), new Point(slave.block.bv.Left, slave.iv.Top + slave.block.bv.Top + 10));
        }
        public void RemoveNet()
        {
            for(int i=0;i<nodelist.Count;i++)
            {
                block.bv.innerDiagram.Controls.Remove(nodelist[i]);
            }
            
            master.innernetList.Remove(this);
            slave.innernet = null;

        }
    }
}
