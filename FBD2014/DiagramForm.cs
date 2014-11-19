using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBD2014.Model.ElementCreators;
using System.Drawing;
using FBD2014.Model;

namespace FBD2014
{
    public partial class DiagramForm : Form
    {
        public bool netcreating = false;
        public Color netcolor = new Color();
        public Point creatednetfirst, creatednetsecond;
        public bool rightnettipe=true;
        public OutputModel creatednetmaster;
        public InputModel creatednetslave;
       
        public DiagramForm()
        {
            InitializeComponent();
            this.MdiParent = ViewModel.ViewModel.mf;
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void добавитьСоставнойБлокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.ViewModel.CreateNewElement(typeof(HardBlockPrimitive));
        }

        private void DiagramForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (netcreating)
            {
                Graphics g = CreateGraphics(); ; 
                creatednetsecond = new Point(e.X, e.Y);
                g.Clear(this.BackColor);
                Pen p=new System.Drawing.Pen(netcolor,2F);
                g.DrawLine(p, creatednetfirst, creatednetsecond);

            }
        }

        private void DiagramForm_Click(object sender, EventArgs e)
        {
            netcreating = false;
            this.Invalidate();
        }
    }
}
