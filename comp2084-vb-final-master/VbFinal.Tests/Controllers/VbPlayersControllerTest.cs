using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using VbFinal.Controllers;
using Moq;
using VbFinal.Models;

namespace VbFinal.Tests.Controllers
{
    [TestClass]
    public class VbPlayersControllerTest
    {
        VbPlayersController controller;
        Mock<IMockVbPlayer> mock;
        List<VbPlayer> vbPlayers;

        [TestInitialize]
        public void TestInitialize()
        {
            mock = new Mock<IMockVbPlayer>();

            vbPlayers = new List<VbPlayer>
            {
                new VbPlayer
                {
                    VbPlayerId = 961,
                    FirstName = "Lori",
                    Lastname = "S",
                    Photo = "https://img.icons8.com/color/384/beach-volleyball.png"
                },
                new VbPlayer
                {
                    VbPlayerId = 961,
                    FirstName = "Zak",
                    Lastname = "N",
                    Photo = "https://img.icons8.com/ultraviolet/384/beach-volleyball.png"
                }
            };

            mock.Setup(m => m.VbPlayers).Returns(vbPlayers.AsQueryable());
            controller = new VbPlayersController(mock.Object);
        }

             [TestMethod]
        public void ViewLoads()

        {
            //act

            ViewResult value = controller.Index() as ViewResult;

            //Assert

            Assert.AreEqual("Index", value.ViewName);

        }

        [TestMethod]

        public void IndexValidLoadsVbPlayers()

        {
            // act

            RedirectToRouteResult value = controller.DeleteConfirmed(700) as RedirectToRouteResult;

            var valuelist = value.RouteValues.ToArray();

            // assert

            Assert.AreEqual("Index", valuelist[0].Value);

        }

        [TestMethod]

        public void EditLoadsValidId()
        {
            // act

            RedirectToRouteResult value = controller.Edit(vbPlayers[0]) as RedirectToRouteResult;

            // assert

            Assert.AreEqual("Index", value.RouteValues["action"]);
        }
        [TestMethod]

        public void EditLoadsVbPlayerValidId()
        {
            controller.ModelState.AddModelError("Explanation", "error details");

            // act

            ViewResult value = controller.Edit(vbPlayers[0]) as ViewResult;

            // assert

            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void EditInvalidId()

        {
            // arrange

            RedirectToRouteResult value = controller.DeleteConfirmed(300) as RedirectToRouteResult;

            // act

            var valuelist = value.RouteValues.ToArray();

            // assert

            Assert.AreEqual("Index", valuelist[0].Value);

        }
        [TestMethod]

        public void EditSaveValid()
        {
            // act

            RedirectToRouteResult value = controller.Edit(vbPlayers[0]) as RedirectToRouteResult;

            // assert

            Assert.AreEqual("Index", value.RouteValues["action"]);
        }


    }
}

