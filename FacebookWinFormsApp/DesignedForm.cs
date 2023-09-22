// Ignore Spelling: Facebook

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using CefSharp.DevTools.CSS;
using CefSharp.DevTools.Debugger;
using CefSharp.DevTools.Preload;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class DesignedForm : Form
    {
        private LoginResultProxy m_LoginResultProxy;
        private IFactory factory;

        public DesignedForm()
        {
            InitializeComponent();
            postsListBox.BringToFront();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            factory = FacebookFactory.Instance;
        }

        private List<Post> m_Posts = new List<Post>();
        private List<Album> m_AlbumsWithLinks = new List<Album>();
        private List<Group> m_Groups = new List<Group>();

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResultProxy == null || !m_LoginResultProxy.IsLoggedIn())
            {
                Login();
            }
        }

        private void Login()
        {
            /*(This is my app ID: "617465447233798"*/
            string[] permissions =
            {
                "email",
                "public_profile",
                "user_likes",
                "user_posts",
                "user_managed_groups",
                "groups_access_member_info",
                "pages_manage_posts",
            };
            m_LoginResultProxy = new LoginResultProxy(textBoxAppID.Text, permissions);

            if (m_LoginResultProxy.IsLoggedIn())
            {
                int flag = 0;
                try
                {
                    loginButton.Text = $"Logged in as {m_LoginResultProxy.GetLoginResult().LoggedInUser.Name}";
                }
                catch (Exception exception)
                {
                    flag = 1;
                    MessageBox.Show("Login Failed :" + exception.Message);
                }

                if (flag == 0)
                {
                    nameLabel.Text = $"Name: {m_LoginResultProxy.GetLoginResult().LoggedInUser.Name}";
                    genderLable.Text = $"Gender: {m_LoginResultProxy.GetLoginResult().LoggedInUser.Gender}";
                    loginButton.BackColor = Color.LightGreen;
                    profilePictureBox.ImageLocation = m_LoginResultProxy.GetLoginResult().LoggedInUser.PictureNormalURL;
                    this.Controls.EnableAll();
                    //postsButton.Enabled = true;
                    //albumsButton.Enabled = true;
                    //groupsButton.Enabled = true;
                    //newPostButton.Enabled = true;
                    //mostLikedButton.Enabled = true;
                    //numberOfPhotosButton.Enabled = true;
                    textBoxAppID.Enabled = false;
                    loginButton.Enabled = false;
                    //logoutButton.Enabled = true;
                }
                else
                {
                    m_LoginResultProxy = null;
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (m_LoginResultProxy.GetLoginResult() != null)
            {
                m_LoginResultProxy.Logout();
                FacebookService.Logout();
                profilePictureBox.ImageLocation = string.Empty;
                genderLable.Text = string.Empty;
                nameLabel.Text = string.Empty;
                loginButton.Text = "Login";
                loginButton.BackColor = logoutButton.BackColor;
                postsListBox.GetListBox.Items.Clear();
                albumsListBox.GetListBox.Items.Clear();
                postsButton.Enabled = false;
                groupsButton.Enabled = false;
                albumsButton.Enabled = false;
                newPostButton.Enabled = false;
                mostLikedButton.Enabled = false;
                numberOfPhotosButton.Enabled = false;
                textBoxAppID.Enabled = true;
                loginButton.Enabled = true;
                logoutButton.Enabled = false;
                postsListBox.BringToFront();
            }
        }

        private void PostsButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                postsButton.Enabled = false;
                if (m_Posts.Count == 0)
                {
                    SetPosts(postsListBox.GetListBox, m_LoginResultProxy.GetLoginResult());
                }

                postsListBox.SetPosts = m_Posts;
                this.Invoke(new Action(() =>
                {
                    numberOfPhotosButton.Enabled = true;
                    newPostButton.Enabled = true;
                    albumsButton.Enabled = true;
                    groupsButton.Enabled = true;
                    mostLikedButton.Enabled = true;
                }));
            });

            thread.Start();
            postsListBox.BringToFront();
        }

        private void AlbumsButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                albumsButton.Enabled = false;
                if (m_AlbumsWithLinks.Count == 0)
                {
                    LoadAlbums(albumsListBox.GetListBox, m_LoginResultProxy.GetLoginResult());
                }

                albumsListBox.SetAlbums = m_AlbumsWithLinks;
                this.Invoke(new Action(() =>
                {
                    numberOfPhotosButton.Enabled = true;
                    newPostButton.Enabled = true;
                    groupsButton.Enabled = true;
                    postsButton.Enabled = true;
                    mostLikedButton.Enabled = true;
                }));
            });
            thread.Start();
            albumsListBox.BringToFront();
        }

        private void GroupsButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                groupsButton.Enabled = false;
                if (m_Groups.Count == 0)
                {
                    LoadGroups(groupsListBox.GetListBox, m_LoginResultProxy.GetLoginResult());
                }

                this.Invoke(new Action(() =>
                {
                    numberOfPhotosButton.Enabled = true;
                    newPostButton.Enabled = true;
                    albumsButton.Enabled = true;
                    postsButton.Enabled = true;
                    mostLikedButton.Enabled = true;
                }));
            });
            thread.Start();
            groupsListBox.BringToFront();
        }

        public void SetPosts(ListBox o_Posts, LoginResult i_LoginResult)
        {
            if (i_LoginResult != null)
            {
                foreach (var postObject in i_LoginResult.LoggedInUser.Posts)
                {
                    string description = postObject.Description;
                    string likes = "0";
                    List<string> comments = new List<string>();
                    if (description != null)
                    {
                        try
                        {
                            likes = postObject.LikedBy.ToString();
                        }
                        catch (Exception)
                        {
                            likes = "0";
                        }

                        foreach (var comment in postObject.Comments)
                        {
                            if (comment != null)
                            {
                                comments.Add(comment.ToString());
                            }
                        }

                        Post currentPost = factory.CreatePost(description, likes, comments);
                        m_Posts.Add(currentPost);
                        o_Posts.Items.Add(currentPost.Description);
                    }
                }
            }
        }

        public void LoadAlbums(ListBox o_Albums, LoginResult i_LoginResult)
        {
            if (i_LoginResult != null)
            {
                foreach (var albumObject in i_LoginResult.LoggedInUser.Albums)
                {
                    string nameOfTheAlbum = albumObject.Name;
                    string linkToTheAlbum = albumObject.Link;
                    long? numberOfPhotos = albumObject.Count;
                    string pictureUrl = albumObject.PictureAlbumURL;
                    Album album = factory.CreateAlbum(nameOfTheAlbum, linkToTheAlbum, numberOfPhotos, pictureUrl);
                    m_AlbumsWithLinks.Add(album);
                    o_Albums.Items.Add(nameOfTheAlbum);
                }
            }
        }

        public void LoadGroups(ListBox o_Groups, LoginResult i_loginResult)
        {
            if (i_loginResult != null)
            {
                try
                {
                    foreach (var groupObj in i_loginResult.LoggedInUser.Groups)
                    {
                        string nameOfTheGroup = groupObj.Name;
                        string descriptionOfTheGroup = groupObj.Description;
                        Group group = factory.CreateGroup(nameOfTheGroup, descriptionOfTheGroup);
                        m_Groups.Add(group);
                        o_Groups.Items.Add(nameOfTheGroup);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't load user groups");
                }
            }
        }

        private void NewPostButton_Click(object sender, EventArgs e)
        {
            newPostButton.Enabled = false;
            numberOfPhotosButton.Enabled = true;
            groupsButton.Enabled = true;
            albumsButton.Enabled = true;
            postsButton.Enabled = true;
            mostLikedButton.Enabled = true;
            newPostInsideForm.LoginResult = m_LoginResultProxy.GetLoginResult();
            newPostInsideForm.BringToFront();
        }

        private void MostLikedButton_Click(object sender, EventArgs e)
        {
            if (m_Posts.Count == 0)
            {
                SetPosts(postsListBox.GetListBox, m_LoginResultProxy.GetLoginResult());
            }

            mostLikedButton.Enabled = false;
            numberOfPhotosButton.Enabled = true;
            postsButton.Enabled = true;
            newPostButton.Enabled = true;
            albumsButton.Enabled = true;
            groupsButton.Enabled = true;
            lableBoxesFirst.BringToFront();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("The most liked Post is: ");
            Post mostLikedPost = GetMostLikedPost(m_Posts);
            if (mostLikedPost != null)
            {
                if (mostLikedPost.Likes != "0")
                {
                    stringBuilder.AppendLine($"{mostLikedPost.Description.Substring(0, 60)} ...");
                    stringBuilder.AppendLine($"With {mostLikedPost.Likes} likes");
                }
                else
                {
                    stringBuilder.Clear();
                    stringBuilder.AppendLine("All posts likes are 0 or the service not working right now");
                }

                lableBoxesFirst.GetLabel.Text = stringBuilder.ToString();
            }
            else
            {
                lableBoxesFirst.GetLabel.Text = "Couldn't fetch likes";
            }
        }

        public Post GetMostLikedPost(List<Post> i_Posts)
        {
            List<string> empty = new List<string>();

            Post currentPost = factory.CreatePost(string.Empty, "0", empty);
            if (i_Posts != null)
            {
                currentPost = i_Posts[0];
                int maxlikes = 0;
                foreach (Post post in i_Posts)
                {
                    int currentPostLikes = int.Parse(post.Likes);
                    if (maxlikes < currentPostLikes)
                    {
                        maxlikes = currentPostLikes;
                        currentPost = post;
                    }
                }
            }

            return currentPost;
        }

        private void NumberOfPhotosButton_Click(object sender, EventArgs e)
        {
            if (m_AlbumsWithLinks.Count == 0)
            {
                LoadAlbums(albumsListBox.GetListBox, m_LoginResultProxy.GetLoginResult());
            }

            numberOfPhotosButton.Enabled = false;
            mostLikedButton.Enabled = true;
            postsButton.Enabled = true;
            newPostButton.Enabled = true;
            albumsButton.Enabled = true;
            groupsButton.Enabled = true;
            numberOfPhotosLableForm.BringToFront();
            string totalNumberOfPhotos = GetTotalNumberOfPhotos(m_AlbumsWithLinks);
            numberOfPhotosLableForm.GetLabel.Text = $"The total number of photos is: {totalNumberOfPhotos}";
        }

        public string GetTotalNumberOfPhotos(List<Album> i_Albums)
        {
            long? totalNumberOfPhotos = 0;
            if (i_Albums != null)
            {
                foreach (Album album in i_Albums)
                {
                    long? currentAlbumPhotos = album.NumberOfPhotos;
                    totalNumberOfPhotos += currentAlbumPhotos;
                }
            }

            return totalNumberOfPhotos.ToString();
        }
    }
}
