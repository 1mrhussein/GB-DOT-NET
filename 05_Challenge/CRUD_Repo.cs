using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class CRUD_Repo
    {
        List<CRUD> crudList = new List<CRUD>();
        // to add customers in the dict.
        public void AddToList(CRUD crud)
        {
            crudList.Add(crud);
        }
        // to get the listed customers in the dict.
        public List<CRUD> GetCustomers()
        {
            return crudList;
        }

        // delete
        public void Delete(CRUD cRUD)
        {
            crudList.Remove(cRUD);
        } //delete by ...
        public bool DeleteCust(int custID, string custLname)
        {
            bool D_succeed = false;
            foreach (CRUD item in crudList)
            {
                if (item.CustomerID == custID && item.CustomerLastName == custLname)
                {
                    Delete(item);
                    D_succeed = true;
                    break;
                }
            }
            return D_succeed;
        }
        // update 
        public CRUD CustUpdae(string fName, string lName)
        {
            CRUD udCrud = new CRUD();
            foreach (CRUD item in crudList)
            {
                if (item.CustomerFirstName == fName && item.CustomerLastName == lName)
                {
                    udCrud = item;
                }
            }
            return udCrud;
        }

    }
}
