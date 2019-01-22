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
    }
}