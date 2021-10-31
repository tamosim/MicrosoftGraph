using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftGraph.Core
{
    public class GraphSettings
    {
        public string CliendId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
    }
}
