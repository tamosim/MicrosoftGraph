using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftGraph.Core
{
    public class GraphClient
    {
        private GraphServiceClient serviceClient;
        public GraphServiceClient ServiceClient
        {
            get
            {
                if (serviceClient != null)
                {
                    return serviceClient;
                }

                serviceClient = new GraphServiceClient(AuthenticationProvider.AuthenticationProvider);
                return serviceClient;
            }
        }

        public GraphHelper AuthenticationProvider { get; }
        public GraphClient(GraphHelper authProvider)
        {

            ///adkhbsdhfbkjdbfjhfbjhdfvhkbdfkhd
            AuthenticationProvider = authProvider;
        }
    }
}
