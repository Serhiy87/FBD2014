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
using FBD2014.ViewModel;
namespace FBD2014
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            ViewModel.ViewModel.mf = this;
            
        }

        private void иToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.ViewModel.CreateNewElement(typeof(AND));
            
        }

        private void создатьПрогораммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiagramForm df = new DiagramForm();
            ViewModel.ViewModel.mainDiagram = df;
            ViewModel.ViewModel.currentDiagram = df;
            df.Show();
            ViewModel.ViewModel.CreateNewElement(typeof(ArduinoMega));
            df.Controls[df.Controls.Count - 1].Left = df.Width/2-50;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (ViewModel.ViewModel.CurrentBlock.type == "Controller")
            {
                ViewModel.ViewModel.setMainDiagram();
            }
            else
            {
                ViewModel.ViewModel.SetCurrentDiagram(ViewModel.ViewModel.upperBlock.bv);
            }
            
          
        }

        private void сохранитьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBD2014.Model.BlockModel bm=new Model.BlockModel();
            SaveLoad.SaveXml(bm, "firstsave");
        }

        private void нЕToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.ViewModel.CreateNewElement(typeof(NOT));
        }
    }
}
