using Covid19_DataEntities;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19_Dashoboard.Controllers
{
    public class CountryInformationController : Controller
    {
        // GET: CountryInformation
        public ActionResult Index()
        {
            RestClient client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            RestRequest request = new RestRequest("countries", Method.GET);

            IRestResponse response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<IEnumerable<CountryInformation>>(response); //<key, value>

            return View(output);     // async later..
        }
    }
}