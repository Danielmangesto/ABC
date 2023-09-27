// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.DevTools.Runtime;

namespace BasicFacebookFeatures
{
    public class PostIterator : InterfaceIterator<Post>
    {
        private List<Post> m_Posts;
        private int m_CurrentIndex;

        public PostIterator(List<Post> posts)
        {
            m_Posts = posts;
            m_CurrentIndex = 0;
        }

        public int CurrentIndex()
        {
            return m_CurrentIndex;
        }

        public bool HasNext()
        {
            return m_CurrentIndex < m_Posts.Count;
        }

        public Post Next()
        {
            if (HasNext())
            {
                Post post = m_Posts[m_CurrentIndex];
                m_CurrentIndex++;
                return post;
            }
            else
            {
                throw new InvalidOperationException("No more posts to iterate.");
            }
        }
    }
}
