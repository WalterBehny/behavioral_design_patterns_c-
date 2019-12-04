using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IAsset
    {
        void accept(IVisitor visitor);
    }
}
