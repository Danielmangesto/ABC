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
    public class AlbumDataLoader : LoadDataTemplateMethod
    {
        public AlbumDataLoader(DesignedForm form)
            : base(form)
        {
        }

        public override void Load(ListBox i_ListAlbum, LoginResult i_LoginResult)
        {
            m_Form.LoadAlbums(i_ListAlbum, i_LoginResult);
        }
    }
}
