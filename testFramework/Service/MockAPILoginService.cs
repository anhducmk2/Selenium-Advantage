using CoreFramework.APICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFramework.Service
{
    public class MockAPILoginService
    {
        public string userLoginPath = "/userlogin";

        private APIResponse LoginRequest(string username, string password)
        {
            APIResponse response = new APIRequest()
                .SetUrl("https://602e2a204410730017c5025a.mockapi.io" + "/userlogin")
                .AddHeader("Content-Type", "application/x-www-form-urlencoded")
                .AddFormData("username", username)
                .AddFormData("password", password)
                .Post();
            return response;
        }
    }
}
