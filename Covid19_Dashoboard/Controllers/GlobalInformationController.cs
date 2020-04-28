using Covid19_DataEntities;
using Covid19_Service;
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
        APIInformationtionService APIInformationtionService = new APIInformationtionService();  //service


        // GET: GlobalInformation
        public ActionResult Index()
        {
            IRestResponse response = APIInformationtionService.GetResponse("all"); 

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<IEnumerable<GlobalInformation>>(response); //<key, value>

            return View(output);
        }
    }
}