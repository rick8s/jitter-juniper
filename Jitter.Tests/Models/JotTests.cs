using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Models;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JotTests
    {
        [TestMethod]
        public void JotEnsureICanCreateInstance()
        {
            //Bootstrap test shows test project and MVC project are connected
            Jot a_jot = new Jot();
            Assert.IsNotNull(a_jot);
        }
        [TestMethod]
        public void JotEnsureJotHasAllTheThings()
        {
            //Make sure we can put all things in and get them out
            //Arrange
            Jot a_jot = new Jot();
            DateTime expected_time = DateTime.Now;
            //Act
            a_jot.JotId = 1;
            a_jot.Content = "My Content";
            a_jot.Date = expected_time;
            a_jot.Author = null; // Will need to define later
            a_jot.Picture = "https://google.com";

            //Assert
            Assert.AreEqual(1, a_jot.JotId);
            Assert.AreEqual("My Content", a_jot.Content);
            Assert.AreEqual(expected_time, a_jot.Date);
            Assert.AreEqual(null, a_jot.Author);
            Assert.AreEqual("https://google.com", a_jot.Picture);
        }

        [TestMethod]
        public void JotEnsureICanUseObjectInitializerSyntax()
        {
            DateTime expected_time = DateTime.Now;
            // Below uses the Jot.cs setter we created by JotEnsureJotHasAllTheThings test to allow us to assign value
            Jot a_jot = new Jot { JotId = 1, Content = "My Content", Date = expected_time, Author = null, Picture = "https://google.com" };

            Assert.AreEqual(1, a_jot.JotId);
            Assert.AreEqual("My Content", a_jot.Content);
            Assert.AreEqual(expected_time, a_jot.Date);
            Assert.AreEqual(null, a_jot.Author);
            Assert.AreEqual("https://google.com", a_jot.Picture);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            //Arrange
            //Act
            //Assert
        }
    }
}
