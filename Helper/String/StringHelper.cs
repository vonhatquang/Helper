using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class StringHelper : IStringHelper
    {
        public string EncodeString(string originString)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(originString));
        }

        public string DecodeString(string encodeString)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(encodeString));
        }
    }
}
