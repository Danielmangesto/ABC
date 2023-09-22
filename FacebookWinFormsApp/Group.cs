// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Group
    {
        private string m_Name;
        private string m_Description;

        public Group(string i_Name, string i_Description)
        {
            m_Name = i_Name;
            m_Description = i_Description;
        }

        public string Name
        {
            get { return m_Name; }
            private set { m_Name = value; }
        }

        public string Description
        {
            get { return m_Description; }
            private set { m_Description = value; }
        }
    }
}
