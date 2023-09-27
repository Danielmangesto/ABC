﻿// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class EnableStrategy : IChangeButtonStrategy
    {
        public void ChangeProperty(Button i_button)
        {
            i_button.Enabled = true;
        }
    }
}
