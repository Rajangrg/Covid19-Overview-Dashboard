using Covid19_DataEntities;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Covid19_Dashoboard.Controllers
{
    public class GlobalInformationController : Controller
    {
        // GET: GlobalInformation
        public ActionResult Index()
        {
           
            RestClient client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            RestRequest request = new RestRequest("all", Method.GET);

        
            IRestResponse response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response); //<key, value>

            GlobalInformation model = new GlobalInformation()
            {
                Cases = output["cases"],
                Deaths = output["deaths"],
                Recovered = output["recovered"],
            };

            return View(model);
        }
    }
}