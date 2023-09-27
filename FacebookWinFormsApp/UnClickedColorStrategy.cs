// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class UnClickedColorStrategy : IChangeButtonStrategy
    {
        public void ChangeProperty(Button i_button)
        {
            i_button.BackColor = Color.FromArgb(85, 87, 102);
        }
    }
}
