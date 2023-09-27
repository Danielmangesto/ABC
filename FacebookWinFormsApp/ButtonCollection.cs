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
    public static class ButtonCollection
    {
        public static void EnableButton(this Button i_Button)
        {
            new ButtonPropertyChanger(new EnableStrategy()).ChangeButtons(i_Button);
        }

        public static void ClickedColorButton(this Button i_Button)
        {
            new ButtonPropertyChanger(new ClickedColorStrategy()).ChangeButtons(i_Button);
        }

        public static void unClickedColorButton(this Button i_Button)
        {
            new ButtonPropertyChanger(new UnClickedColorStrategy()).ChangeButtons(i_Button);
        }
    }
}