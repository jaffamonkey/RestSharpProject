using System;
using System.Net;
using NUnit.Framework;
using RestSharp;

namespace RestSharpProject.Tests
{
    [TestFixture]
    public class BasicRestTest
    {
        [Test]
        public void StatusCode200Test()
        {
            //Arrange
            RestClient client = new RestClient("http://api.github.com");
            RestRequest request = new RestRequest("/rate_limit", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
