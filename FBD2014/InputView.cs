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
    }
}
