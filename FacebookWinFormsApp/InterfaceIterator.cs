// Ignore Spelling: Facebook

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface InterfaceIterator<T>
    {
        bool HasNext();

        T Next();

        int CurrentIndex();
    }
}
