using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    internal interface IViewSettings
    {
        void SetFormRoundRectRgn(Form form,int rgnRadius);
        void SetControlRectRgn(Control control,int rgnRadius);
    }
}
