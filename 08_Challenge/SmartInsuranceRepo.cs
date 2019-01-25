using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class SmartInsuranceRepo
    {
        List<SmartInsurance> listOfDrivers = new List<SmartInsurance>();

        public void AddDriverToList(SmartInsurance smartIns)
        {
            listOfDrivers.Add(smartIns);
        }

        public List<SmartInsurance> GetOutingList()
        {
            return listOfDrivers;
        }
    }
}
