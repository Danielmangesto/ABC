// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class AlbumsIterator : InterfaceIterator<Album>
    {
        private List<Album> m_Albums;
        private int m_CurrentIndex;

        public AlbumsIterator(List<Album> i_Album)
        {
            m_Albums = i_Album;
            m_CurrentIndex = 0;
        }

        public int CurrentIndex()
        {
            return m_CurrentIndex;
        }

        public bool HasNext()
        {
            return m_CurrentIndex < m_Albums.Count;
        }

        public Album Next()
        {
            if (HasNext())
            {
                Album album = m_Albums[m_CurrentIndex];
                m_CurrentIndex++;
                return album;
            }
            else
            {
                throw new InvalidOperationException("No more albums to iterate.");
            }
        }
    }
}
