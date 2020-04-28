using Covid19_DataEntities;
using Covid19_Service;
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

        APIInformationtionService APIInformationtionService = new APIInformationtionService(); //service

        // GET: CountryInformation
        public ActionResult Index()
        {
            IRestResponse response = APIInformationtionService.GetResponse("countries");

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<IEnumerable<CountryInformation>>(response); //<key, value>

            return View(output);     // async later..
        }
    }
}