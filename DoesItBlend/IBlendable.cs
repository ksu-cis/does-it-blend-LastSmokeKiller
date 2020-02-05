using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    public interface IBlendable
    {
        virtual string Blend()
        {
            return "We blend";
        }
    }
}
