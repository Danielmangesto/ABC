// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class Post
    {
        private string m_description;
        private string m_Likes;
        private List<string> m_Comments;

        public Post(string i_Description, string i_Likes, List<string> i_Comments)
        {
            m_Comments = i_Comments;
            m_Likes = i_Likes;
            m_description = i_Description;
        }

        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public string Likes
        {
            get { return m_Likes; }
            set { m_Likes = value; }
        }

        public List<string> Comments
        {
            get { return m_Comments; }
            set { m_Comments = value; }
        }

        public InterfaceIterator<Post> GetIterator()
        {
            return new PostIterator(new List<Post> { this });
        }
    }
}
