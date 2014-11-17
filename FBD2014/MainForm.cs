using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBD2014.Model.ElementCreators.Logic.Basic

namespace FBD2014
{
    public partial class MainForm : Form
    {
        public ViewModel.ViewModel vm;
        public MainForm()
        {
            InitializeComponent();
            DiagramForm df = new DiagramForm();
            df.MdiParent=this;
            df.Show();
            df.Size = df.MaximumSize;
            vm = new ViewModel.ViewModel();
            vm.currentDiagram = df;
            
        }

        private void иToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vm.CreateNewElement(typeof(AND));
        }
    }
}
