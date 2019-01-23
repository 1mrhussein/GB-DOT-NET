using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class OutingsRepository
    {
        List<Outings> listOfOutings = new List<Outings>();

        public void AddOutingToList(Outings outings)
        {
            listOfOutings.Add(outings);
        }

        public List<Outings> GetOutingList()
        {
            return listOfOutings;
        }

        public double CostByType(TypeOfOutings OType)
        {
            double totalCost = 0;
            foreach (Outings item in listOfOutings )
            {
                if (item.Type == OType)
                {
                    totalCost += item.TotalCost;
                }
            } return totalCost;
        }
    }
}