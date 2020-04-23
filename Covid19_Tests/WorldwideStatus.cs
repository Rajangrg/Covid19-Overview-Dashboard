using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_Tests
{
    [TestClass]
    public class WorldwideStatus
    {
        [TestMethod]
        public void TotalWorldWideCases()
        {
            // arrange
            var client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            var request = new RestRequest("all", Method.GET);

            // act
            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, int>>(response); //<key, value>
            int TotalCases = output["cases"]; // [0]
            int TotalDeaths = output["deaths"]; // [1]
            int TotaRecovered = output["recovered"]; // [2]

            // assert

            //<Manual track of the data with fake comparsion>
            //need to automate the logic with data comparison from the _db

            NUnit.Framework.Assert.That(TotalCases, Is.GreaterThan(3), "The case is Decreasing"); 
            NUnit.Framework.Assert.That(TotalDeaths, Is.GreaterThan(3), "The Death is Decreasing");
            NUnit.Framework.Assert.That(TotaRecovered, Is.GreaterThan(3), "The Recovery is Decreasing");
        }
    }
}
