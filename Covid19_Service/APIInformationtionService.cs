using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_Service
{
    public class APIInformationtionService
    {

        public IRestResponse GetResponse(string apiCall)
        {
            RestClient client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            RestRequest request = new RestRequest(apiCall, Method.GET);

            return client.Execute(request);
        } 
    }
}
