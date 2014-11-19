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
    public partial class BlockView : UserControl
    {
        public BlockModel bm;
        public DiagramForm innerDiagram;
        bool isDragging;
        Point p;
        public BlockView()
        {
            InitializeComponent();
            
        }

        private void BlockView_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Top += e.Y - p.Y;
                this.Left += e.X - p.X;
                bm.Top = this.Top;
                bm.Left = this.Left;
                foreach (InputModel item in bm.inputList)
                {
                    if (item.innernet != null)
                        item.innernet.Redrav();
                }
                foreach (OutputModel item in bm.outputList)
                {
                    if (item.innernetList.Count != 0)
                    {
                        foreach (NetModel item2 in item.innernetList)
                            item2.Redrav();
                    }
                }
            }
        }

        private void BlockView_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void BlockView_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            p = e.Location;
            this.BringToFront();
        }

        //private void BlockView_Load(object sender, EventArgs e)
        //{

        //}

        private void BlockView_DoubleClick(object sender, EventArgs e)
        {
            if (!this.bm.isAtom)
            {
                ViewModel.ViewModel.SetCurrentDiagram(this);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bm.parentBlock.bv.innerDiagram.Controls.Remove(this);
            this.bm.parentBlock.innerBlocks.Remove(this.bm);
            foreach (InputModel item in bm.inputList)
            {
                if (item.innernet != null)
                    item.innernet.RemoveNet();
            }
            foreach (OutputModel item in bm.outputList)
            {
                if (item.innernetList.Count != 0)
                {
                    
                    for (int i = 0; i < item.innernetList.Count; i++)
                    {
                        item.innernetList[i].RemoveNet();
                    }
                }
            }

        }
    }
}
