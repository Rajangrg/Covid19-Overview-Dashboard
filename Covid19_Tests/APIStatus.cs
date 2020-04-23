using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RestSharp;

namespace Covid19_Tests
{
    [TestClass]
    public class APIStatus
    {
        [TestMethod]
        public void TestAPIStatusCode()
        {
            // arrange
            var client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            var request = new RestRequest("",Method.GET);

            // act
            var content = client.Execute(request);

            // assert
            NUnit.Framework.Assert.That(content.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }


        [TestMethod]
        public void TestAllCountryAPIStatusCode()
        {
            // arrange
            var client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            var request = new RestRequest("countries", Method.GET);

            // act
            var content = client.Execute(request);

            // assert
            NUnit.Framework.Assert.That(content.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }


        [TestMethod]
        public void TestSingleCountryAPIStatusCode()
        {
            // arrange
            var client = new RestClient("https://coronavirus-19-api.herokuapp.com/");
            var request = new RestRequest("countries/New Zealand", Method.GET);

            // act
            var content = client.Execute(request);

            // assert
            NUnit.Framework.Assert.That(content.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
