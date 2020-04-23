using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class CountryStatus
    {
        [TestMethod]
        public void GetCountryName()
        {
            // arrange
            var client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            var request = new RestRequest("countries/New Zealand", Method.GET);

            // act
            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response); //<key, value>
            string GetCountryName = output["country"];


            // assert
            NUnit.Framework.Assert.AreEqual("New Zealand", GetCountryName);
        }
    }
}
