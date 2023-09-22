using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IFactory
    {
        Post CreatePost(string i_Description, string i_Likes, List<string> i_Comments);

        Album CreateAlbum(string i_Name, string i_Link, long? i_Count, string i_PictureUrl);

        Group CreateGroup(string i_Name, string i_Description);
    }
}
