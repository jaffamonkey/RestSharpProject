using NUnit.Framework;
using RestSharp;
using RestSharpProject.Entities;
using Newtonsoft.Json;

namespace RestSharpProject.Tests
{
    [TestFixture]
    public class DeserializationTest
    {
        /**
         * In this test, I deserializing JSON responses to actual objects
         * I convert an actual resopnse to an instance of that class using JsonConvert
         * After that, i can refer to the contents fo the response by accessing the fields of the object
         */
        [Test]
        public void LoginNameSerializationTest()
        {
            //Arrange
            RestClient client = new RestClient("http://api.github.com");
            RestRequest request = new RestRequest("/users/simonchan2020", Method.GET);

            //Act
            IRestResponse response = client.Execute(request);
            User user = JsonConvert.DeserializeObject<User>(response.Content);

            //Assert
            Assert.That(user.Login, Is.EqualTo("simonchan2020"));
        }
    }
}
