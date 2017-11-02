using System;
using Xunit;
using netatmocore;

namespace NetatmoCore.Tests
{
    public class AuthorizationTests
    {
        [Fact]
        public void Authorization_Success_With_Correct_User()
        {
            // Fill these with own values for testing purpose
            var clientId = "";
            var clientSecret = "";
            var username = "";
            var password = "";
            var device_id = "";

            var auth = new NetatmoAuth();
            var token = auth.Login(clientId, clientSecret, username, password, new[] { NetatmoAuth.READ_STATION});

            var netatmo = new NetAtmoClient(token.access_token);
            
            var result = netatmo.Getthermostatsdata(device_id).Result;
        }
    }
}
