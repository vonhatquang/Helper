using System;
using System.Collections.Generic;
using System.Text;

namespace Helper.WebApi
{
    public class ApiController
    {
        public string Name { get; set; }
        public List<ApiAction> WebApiActions { get; set; }
    }
}
