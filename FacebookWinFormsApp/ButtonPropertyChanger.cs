// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ButtonPropertyChanger
    {
        public IChangeButtonStrategy ChangeStrategy { get; set; }

        public ButtonPropertyChanger(IChangeButtonStrategy i_ChangeStrategy)
        {
            ChangeStrategy = i_ChangeStrategy;
        }

        public void ChangeButtons(Button i_Button)
        {
            ChangeStrategy.ChangeProperty(i_Button);
        }
    }
}
