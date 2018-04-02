using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Controllers;

namespace SistemaParroquia.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ViewHome()
        {
            HomeController controller  = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ViewAbout()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ViewContact()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Contact() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
