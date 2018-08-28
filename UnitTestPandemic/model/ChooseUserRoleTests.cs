using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Pandemic.model;


namespace UnitTestPandemic.model
{
    [TestClass]
    class ChooseUserRoleTests
    {
        [TestMethod]
        public void chooseUserRoleTest()
        {
            //arrange
            string name = "TestName";
            int userRole = 1;

            //act 
            ChooseUserRole.chooseUserRole(name);

            //assert
           
           // Assert.AreEqual(expected, actual, "")
        }
    }
}
