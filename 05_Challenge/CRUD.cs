using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public enum CustomerType { Potential, Current, Past };

    public class CRUD
    {
        public CustomerType Type { get; set; }
        public int CustomerID { get; set; } 
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerMessage { get; set; }

        public CRUD(CustomerType aCustomerType, int aCustomerID, string aCustomerFirstName, string aCustomerLastName, string aCustomerMessage)
        {
            Type = aCustomerType;
            CustomerID = aCustomerID;
            CustomerFirstName = aCustomerFirstName;
            CustomerLastName = aCustomerLastName;
            CustomerMessage = aCustomerMessage;
        }

        public CRUD()
        {

        }
    }
}
