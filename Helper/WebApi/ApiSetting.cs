using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class ApiSetting
    {
        public string WebApiUrl { get; set; }
        public string WebApiPrefix { get; set; }
        public List<ApiController> WebApiControllers { get; set; }
    }
}
