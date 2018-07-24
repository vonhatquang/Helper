using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiHelper
{
    public class WebApiSetting
    {
        public string WebApiUrl { get; set; }
        public string WebApiPrefix { get; set; }
        public List<WebApiController> WebApiControllers { get; set; }
    }
}
