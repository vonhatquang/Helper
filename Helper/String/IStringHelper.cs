using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public interface IStringHelper
    {
        string EncodeString(string originString);
        string DecodeString(string encodeString);
    }
}
