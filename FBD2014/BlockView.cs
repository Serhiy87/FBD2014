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
                ViewModel.ViewModel.SetMainDiagram(this);
            }
        }
    }
}
