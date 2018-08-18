using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autolookup
{
    class TestClipBoard
    {
    }
    public partial class Form1 : Form
    {

        private ClipBoardMonitor cbm = null;

        public Form1()
        {
            //InitializeComponent();
            cbm = new ClipBoardMonitor();
            cbm.NewUrl += cbm_NewUrl;
        }

        private void cbm_NewUrl(string txt)
        {
            //this.label1.Text = txt;
        }

    }

    
}
