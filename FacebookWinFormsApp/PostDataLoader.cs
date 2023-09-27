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
    public class PostDataLoader : LoadDataTemplateMethod
    {
        public PostDataLoader(DesignedForm form)
            : base(form)
        {
        }

        public override void Load(ListBox i_ListPosts, LoginResult i_LoginResult)
        {
            m_Form.SetPosts(i_ListPosts, i_LoginResult);
        }
    }
}
