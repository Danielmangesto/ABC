using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class ControlComponentsCollection
    {
        public static void EnableAll(this Control.ControlCollection i_Controls)
        {
            new ControlPropertyChanger(new EnableStrategy()).ChangeControls(i_Controls);
        }
    }
}
