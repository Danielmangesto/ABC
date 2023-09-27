// Ignore Spelling: app Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class LoginResultProxy
    {
        private LoginResult m_LoginResult;

        public LoginResultProxy(string i_AppID, string[] i_Permissions)
        {
            m_LoginResult = FacebookService.Login(i_AppID, i_Permissions);
        }

        public bool IsLoggedIn()
        {
            return m_LoginResult != null && string.IsNullOrEmpty(m_LoginResult.ErrorMessage);
        }

        public LoginResult GetLoginResult()
        {
            return m_LoginResult;
        }

        public void Logout()
        {
            FacebookService.Logout();
            m_LoginResult = null;
        }
    }
}
