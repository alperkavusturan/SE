using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Data.Authentication;
using Newtonsoft.Json;
using RestSharp;

namespace Dashboard.Data.SEService
{
    public class SEService
    {
        public TResponse CallService<TRequest,TResponse>(TRequest serviceRequest, string endpoint, Method method)
        {
            try
            {
                var client = new RestClient(string.Concat("http://176.53.34.37", endpoint));
                var request = new RestRequest(method);

                var requestBody = JsonConvert.SerializeObject(serviceRequest);

                var auth = new Auth { Username = "abc", Password = "123" };
                var token = new AuthService().GetToken(auth);

                request.AddParameter("application/json", requestBody, ParameterType.RequestBody);
                request.AddHeader("Authorization", string.Concat("Bearer ", token.access_token));

                var response = client.Execute(request);

                return JsonConvert.DeserializeObject<TResponse>(response.Content);
            }
            catch(Exception ex)
            {
                return default;
            }
            
        }
    }
}
