using System.Net;
using NUnit.Framework;
using RestSharp;

namespace RestSharpProject.Tests
{
    [TestFixture]
    public class DataDrivenTest
    {
        [TestCase("Test1", HttpStatusCode.OK, TestName = "Check status code for user Test1")]
        [TestCase("Test2", HttpStatusCode.OK, TestName = "Check status code for user Test2")]
        [TestCase("Zvoq", HttpStatusCode.NotFound, TestName = "Check status code for user Zvoq")]
        public void StatusCodeUsingDataDrivenTest(string username, HttpStatusCode expectedHttpStatusCode)
        {
            //Arrange
            RestClient client = new RestClient("http://api.github.com");
            RestRequest request = new RestRequest($"/users/{username}", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.That(response.StatusCode, Is.EqualTo(expectedHttpStatusCode));
        }
    }
}
