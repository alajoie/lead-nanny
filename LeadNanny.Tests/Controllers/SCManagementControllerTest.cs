using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeadNanny;
using LeadNanny.Controllers;

namespace LeadNanny.Tests.Controllers
{
    [TestClass]
    public class SCManagementControllerTest
    {
        [TestMethod]
        public void SCManagement()
        {
            // Arrange
            SCManagementController controller = new SCManagementController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("SC Quota Management Dashboard", result.ViewBag.Message);
        }
        
    }
}
