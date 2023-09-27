// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacebookFactory : IFactory
    {
        private static FacebookFactory instance;

        private FacebookFactory()
        {
        }

        public static FacebookFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FacebookFactory();
                }

                return instance;
            }
        }

        public Post CreatePost(string i_Description, string i_Likes, List<string> i_Comments)
        {
            return new Post(i_Description, i_Likes, i_Comments);
        }

        public Album CreateAlbum(string i_Name, string i_Link, long? i_Count, string i_PictureUrl)
        {
            return new Album(i_Name, i_Link, i_Count, i_PictureUrl);
        }

        public Group CreateGroup(string i_Name, string i_Description)
        {
            return new Group(i_Name, i_Description);
        }
    }
}
