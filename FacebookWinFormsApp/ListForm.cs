// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class ListForm : UserControl
    {
        private List<Post> m_Posts;
        private List<Album> m_Albums;

        public ListForm()
        {
            InitializeComponent();
        }

        public ListBox GetListBox
        {
            get { return ListBoxInsideForm; }
        }

        public List<Post> SetPosts
        {
            set { m_Posts = value; }
        }

        public List<Album> SetAlbums
        {
            set { m_Albums = value; }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_Posts != null)
            {
                int index = ListBoxInsideForm.SelectedIndex;
                DialogResult dialogResult = MessageBox.Show("Do you want to see the full post?", $"post number: {index}", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(m_Posts[index].Description, $"Post number: {index}");
                }
            }
            else if (m_Albums != null)
            {
                string name = ListBoxInsideForm.Text;
                int index = ListBoxInsideForm.SelectedIndex;
                pictureBoxEvent.Load(m_Albums[index].picture);
                DialogResult dialogResult = MessageBox.Show("Do you want to see the album?", $"Album name: {name}", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(m_Albums[index].Link);
                }
            }
        }
    }
}
