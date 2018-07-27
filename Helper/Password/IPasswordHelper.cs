using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public interface IPasswordHelper
    {
        string EncodePassword(string originPassword);
        //string DecodePassword(string encodePassword);
        bool ComparePassword(string password, string dbPassword);
    }
}
