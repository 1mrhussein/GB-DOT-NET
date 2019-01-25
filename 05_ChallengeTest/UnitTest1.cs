using System;
using _05_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ChallengeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testing_IfCreateSucceed()
        {
            CRUD_Repo crRepo = new CRUD_Repo();

            CRUD cr1 = new CRUD(CustomerType.Current, 1, "F1", "L1", "M1");
            CRUD cr2 = new CRUD(CustomerType.Potential, 1, "F2", "L2", "M2");
            CRUD cr3 = new CRUD(CustomerType.Past, 1, "F3", "L3", "M3");
            //Arrange
            crRepo.AddToList
            //Act

            //Assert

        }
    }
}
