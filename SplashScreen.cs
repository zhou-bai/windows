using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookshop.utils;

namespace Bookshop
{
    public partial class SplashScreen : Form
    {
        Random rd = new Random();
        public SplashScreen()
        {
            InitializeComponent();
            mouseMoveController1.Form = this;
            mouseMoveController1.Add(new Control[] {this, BackGround });
        }
        private void timerprogressBar_Tick(object sender, EventArgs e)
        {
            if (panelprogressBar.Width > 560)
            {
                panelprogressBar.Width += 3;
            }
            else
            {
                panelprogressBar.Width += rd.Next(0,11);
            }
            if (panelprogressBar.Width > 700)
            {
                timerprogressBar.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
