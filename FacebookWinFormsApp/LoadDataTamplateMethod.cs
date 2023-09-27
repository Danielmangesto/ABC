// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public abstract class LoadDataTemplateMethod
    {
        protected DesignedForm m_Form;

        public LoadDataTemplateMethod(DesignedForm form)
        {
            m_Form = form;
        }

        public abstract void Load(ListBox i_ListPosts, LoginResult i_LoginResult);
    }
}
