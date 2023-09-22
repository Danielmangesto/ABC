using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class ControlPropertyChanger
    {
        public IChangeControlStrategy ChangeStrategy { get; set; }

        public ControlPropertyChanger(IChangeControlStrategy i_ChangeStrategy)
        {
            ChangeStrategy = i_ChangeStrategy;
        }

        public void ChangeControls(Control.ControlCollection i_ControlCollection)
        {
            foreach (Control control in i_ControlCollection.Owner.Controls)
            {
                if (control is Button)
                {
                    ChangeStrategy.ChangeProperty(control);
                }
            }
        }
    }
}
