using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiHelper
{
    public class WebApiController
    {
        public string Name { get; set; }
        public List<WebApiAction> WebApiActions { get; set; }
    }
}
