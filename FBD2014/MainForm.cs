using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBD2014.Model.ElementCreators.Logic.Basic;
using FBD2014.Model.ElementCreators.Controllers;

namespace FBD2014
{
    public partial class MainForm : Form
    {
        public ViewModel.ViewModel vm;
        DiagramForm df;
        public MainForm()
        {
            InitializeComponent();
            df = new DiagramForm();
            df.MdiParent=this;
            df.Show();
            df.Size = df.MaximumSize;
            vm = new ViewModel.ViewModel();
            ViewModel.ViewModel.mf = this;
            ViewModel.ViewModel.currentDiagram = df;
            
        }

        private void иToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vm.CreateNewElement(typeof(AND));
        }

        private void создатьПрогораммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vm.CreateNewElement(typeof(ArduinoMega));
            df.Controls[df.Controls.Count - 1].Left = df.Width/2-50;
        }
    }
}
