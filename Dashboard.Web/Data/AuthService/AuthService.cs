using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Web.Data.Services
{
    public class AuthService
    {
        public Token GetToken(Auth auth)
        {
            try
            {
                var client = new RestClient("http://176.53.34.37:8181/api/auth/getToken");
                var request = new RestRequest(Method.POST);
                var requestBody = JsonConvert.SerializeObject(auth);
                request.AddParameter("application/json", requestBody, ParameterType.RequestBody);

                var response = client.Execute(request).Content;

                return JsonConvert.DeserializeObject<Token>(response);
            }
            catch (Exception ex)
            {
                return default;
            }

        }
    }
}
