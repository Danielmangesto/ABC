// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LabelForm : UserControl
    {
        public LabelForm()
        {
            InitializeComponent();
        }

        public Label GetLabel
        {
            get { return MostLable; }
        }

        private void LableBoxes_Load(object sender, EventArgs e)
        {
        }
    }
}
