using Bunit;
using Moq;

namespace AWSAuthentication.UnitTest
{
    public class Tests
    {
        private Bunit.TestContext testContext;
        [SetUp]
        public void Setup()
        {
            testContext=new Bunit.TestContext();
        }

        [TearDown]
        public void TearDown()
        {
            testContext.Dispose();
        }

        [Test]
        public void CheckAllElements_IndexComponent()
        {
            var component = testContext.RenderComponent<AWSAuthentication.Pages.Index>();
            Assert.That(component.Markup.Contains("<h1>Hello, Wrlcome To AWS Authentication!</h1>"));
        }

        [Test]
        public void CheckAllElements_LoginComponent()
        {
            var component = testContext.RenderComponent<AWSAuthentication.Pages.Login>();
            Assert.That(component.Markup.Contains("<h1>User Login</h1>"));
            var achorLink = component.FindAll("a");
            Assert.That(achorLink.Count, Is.EqualTo(1));
            var achorLinkContent = achorLink.FirstOrDefault(aLink => aLink.InnerHtml.Contains("here"));
            Assert.IsNotNull(achorLinkContent);
        }

        //[Test]
        //public void CheckAllElements_UserInfoComponent()
        //{
        //    var component = testContext.RenderComponent<AWSAuthentication.Components.UserInfo>();                                                    
        //        var initialExpectedHtml =
        //                    @"<h3>User Informatino</h3>
        //        <h1>Loading Please Wait...</h1>";
        //    component.MarkupMatches(initialExpectedHtml);            
        //}

        //[Test]
        //public void Check_UserInfoComponentWithData()
        //{
        //    var component = testContext.RenderComponent<AWSAuthentication.Components.UserInfo>();
        //    Mock<AWSAuthentication.Models.UserResponse> mockUserResponse = new Mock<AWSAuthentication.Models.UserResponse>();

        //}
    }
}