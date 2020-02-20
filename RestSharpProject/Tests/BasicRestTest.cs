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

        [Test]
        public void ContentTypeJSONTest()
        {
            //Arrange
            RestClient client = new RestClient("http://api.github.com");
            RestRequest request = new RestRequest("/rate_limit", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.That(response.ContentType, Is.EqualTo("application/json; charset=utf-8"));
        }

        [Test]
        public void ServerTest()
        {
            //Arrange
            RestClient client = new RestClient("http://api.github.com");
            RestRequest request = new RestRequest("/rate_limit", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            Assert.That(response.Server, Is.EqualTo("GitHub.com"));
        }
    }
}
