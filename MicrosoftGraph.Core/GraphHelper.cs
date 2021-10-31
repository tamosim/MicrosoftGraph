using Microsoft.Graph;
using Microsoft.Identity.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftGraph.Core
{
    public class GraphHelper
    {
        private DelegateAuthenticationProvider authenticationProvider;
        public string[] Scopes { get; } = { "User.Read", "User.ReadWrite", "User.Read.All" };

        public DelegateAuthenticationProvider AuthenticationProvider
        {
            get
            {
                GetGraphClientAuthProvider();
                return authenticationProvider;
            }
        }
        public ITokenAcquisition Token { get; }

        public GraphHelper(ITokenAcquisition token)
        {
            Token = token;
        }

        private DelegateAuthenticationProvider GetGraphClientAuthProvider()
        {
            if (authenticationProvider != null)
            {
                return authenticationProvider;
            }

            authenticationProvider = new DelegateAuthenticationProvider(async x => {
                var accessToken = await Token.GetAccessTokenForUserAsync(Scopes);
                x.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            });


            return authenticationProvider;
        }
    }
}
