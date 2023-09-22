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
    public class Album
    {
        private string m_Name;
        private string m_Link;
        private long? m_Count;
        private string m_pictureUrl;

        public Album(string i_name, string i_link, long? i_count, string pictureUrl)
        {
            m_Link = i_link;
            m_Name = i_name;
            m_Count = i_count;
            m_pictureUrl = pictureUrl;
        }

        public string Link
        {
            get { return m_Link; }
            private set { m_Link = value; }
        }

        public string picture
        {
            get { return m_pictureUrl; }
            private set { m_pictureUrl = value; }
        }

        public long? NumberOfPhotos
        {
            get { return m_Count; }
            private set { m_Count = value; }
        }
    }
}
