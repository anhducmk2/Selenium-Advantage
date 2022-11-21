using NUnit.Framework;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class HomePageTest : ProjectNUnitTestSetup
    {
        [Test]
        public void HomepageTest()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.SelectElement();
            homePage.CheckDisplayElement();
            homePage.SelectWebTable();
            homePage.CheckDisplayWebTable();
            homePage.GoToAddScreen();
        }


    }
}
