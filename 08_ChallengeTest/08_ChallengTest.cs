using System;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_ChallengeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testing_IfPremuim_Varies_UpOnDriver_WayOfDriving()
        {
            //Arrange
            SmartInsuranceRepo repository = new SmartInsuranceRepo();

            SmartInsurance smI0 = new SmartInsurance(55.00m, false, false, false, false);
            SmartInsurance smI2 = new SmartInsurance(68.75m, true, true, true, true);

            // Act

            // Assert
           
        }
    }
}
