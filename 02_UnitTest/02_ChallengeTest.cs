using System;
using _02_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_UnitTest
{
    [TestClass]
    public class UnitTestFor_02_Challenge
    {
        [TestMethod]
        public void Test_AddOutingToList_Should_Add_OutingToListAndShouldDisplay()
        {
            // Arrange 
            OutingsRepository repository = new OutingsRepository();

            Outings outings0 = new Outings(TypeOfOutings.AmusementPark, 10, new DateTime(2019, 02, 02), 5);
            Outings outings1 = new Outings(TypeOfOutings.Concert, 10, new DateTime(2019, 02, 02), 5);
            Outings outings2 = new Outings(TypeOfOutings.Bowling, 10, new DateTime(2019, 02, 02), 5);
            Outings outings3 = new Outings(TypeOfOutings.Bowling, 10, new DateTime(2019, 02, 02), 5);
            repository.AddOutingToList(outings0);
            repository.AddOutingToList(outings1);
            repository.AddOutingToList(outings2);
            repository.AddOutingToList(outings3);
            // Act
            int actual = repository.GetOutingList().Count;
            int expected = 4;
            // Assert 
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_CostByType_Should_Show_CostByType()
        {
            // Assert
            OutingsRepository repository = new OutingsRepository();

            Outings outings0 = new Outings(TypeOfOutings.AmusementPark, 10, new DateTime(2019, 02, 02), 5);
            Outings outings1 = new Outings(TypeOfOutings.Concert, 10, new DateTime(2019, 02, 02), 10);
            Outings outings2 = new Outings(TypeOfOutings.Bowling, 20, new DateTime(2019, 02, 02), 5);
            Outings outings3 = new Outings(TypeOfOutings.Bowling, 20, new DateTime(2019, 02, 02), 5);
            repository.AddOutingToList(outings0);
            repository.AddOutingToList(outings1);
            repository.AddOutingToList(outings2);
            repository.AddOutingToList(outings3);

            // Act
            double actualAMP = repository.CostByType(TypeOfOutings.AmusementPark);
            double expectedAMP = 50d;

            double actualB = repository.CostByType(TypeOfOutings.Bowling);
            double expectedB = 200d;

            double actualC = repository.CostByType(TypeOfOutings.Concert);
            double expectedC = 100d;
            // Assert 
            Assert.AreEqual(expectedAMP, actualAMP);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }
    }
}