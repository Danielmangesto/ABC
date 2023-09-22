// Ignore Spelling: Facebook

using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class NewPostForm : UserControl
    {
        private FacebookWrapper.LoginResult m_LoginResult = new LoginResult();

        public NewPostForm()
        {
            InitializeComponent();
        }

        public LoginResult LoginResult
        {
            set { m_LoginResult = value; }
        }

        public string TextBox1Text
        {
            get { return textBox1.Text; }
        }

        private void SendNewPostButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoginResult.LoggedInUser.PostStatus(textBox1.Text);
                MessageBox.Show("Status Posted!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
