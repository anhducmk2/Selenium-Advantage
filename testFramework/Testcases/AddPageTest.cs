using NUnit.Framework;
using testFramework.PageObject;
using testFramework.TestSetup;

namespace testFramework.Testcases
{
    [TestFixture]
    public class AddPageTest : ProjectNUnitTestSetup
    {
        [Test]
        public void AddpageTest()
        {
            AddPage AddPage = new AddPage(_driver);
            AddPage.SelectElement();
            AddPage.CheckDisplayElement();
            AddPage.SelectWebTable();
            AddPage.CheckDisplayWebTable();
            AddPage.GoToAddScreen();
            AddPage.EnterValidData();
            AddPage.ClickSubmit();
        }
    }
}
