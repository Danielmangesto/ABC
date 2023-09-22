using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class EnableStrategy : IChangeControlStrategy
    {
            public void ChangeProperty(Control i_Control)
            {
                i_Control.Enabled = true;
            }
    }
}
