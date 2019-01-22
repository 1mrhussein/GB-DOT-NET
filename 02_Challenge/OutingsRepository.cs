using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    class OutingsRepository
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
            switch (OType)
            {
                case TypeOfOutings.Golf:
                    totalCost += totalCost;
                break;
                case TypeOfOutings.Bowling:
                    totalCost += totalCost;
                    break;
                case TypeOfOutings.AmusementPark:
                    break;
                case TypeOfOutings.Concert:
                    break;
            }
            return totalCost;
        }
    }
}