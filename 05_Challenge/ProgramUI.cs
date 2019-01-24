using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    class ProgramUI
    {
        CRUD_Repo crudRepo = new CRUD_Repo();
        Dictionary<int, CRUD> DC = new Dictionary<int, CRUD>();

        internal void Run()
        {
            bool running = true;
            int choice;

            while (running)
            {
                Console.WriteLine("--------------Please enter your choice---------------: \n" +
                    "\n\t1. To add\n" +
                    "\t2. To delete\n" +
                    "\t3. To update\n" +
                    "\t4. Display all\n" +
                    "\t5. To exit the program\n");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        AddingToList();
                        break;
                    case 2:
                        RemoveFromListBySpecification();
                        break;
                    case 3:
                        CustUpdate();
                        break;
                    case 4:
                        DisplayAll();
                        break;
                    case 5:
                        // exit
                        running = false;
                        break;
                }
                Console.Clear();
            }
        }
        // add method
        public void AddingToList()
        {
            CRUD newCRUD = new CRUD();

            Console.WriteLine("--------------Please enter your choice---------------: \n" +
                    "\n\t1. To add Potential customer\n" +
                    "\t2. To add Current customer\n" +
                    "\t3. To add Past customer\n" +
                    "\t4. To exit the program\n");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    newCRUD.Type = CustomerType.Potential;
                    newCRUD.CustomerMessage = "We currently have the lowest rates on Helicopter Insurance!";
                    break;
                case 2:
                    newCRUD.Type = CustomerType.Current;
                    newCRUD.CustomerMessage = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
                    break;
                case 3:
                    newCRUD.Type = CustomerType.Past;
                    newCRUD.CustomerMessage = "It's been a long time since we've heard from you, we want you back";
                    break;
                default:
                    Console.WriteLine("You entered wrong choice: please select 1-3\n");
                    Console.ReadLine();
                    AddingToList();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Please enter the customer ID--Must be unique:\n");
            newCRUD.CustomerID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the customer first name:\n");
            newCRUD.CustomerFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the customer last name:\n");
            newCRUD.CustomerLastName = Console.ReadLine();
            Console.WriteLine(newCRUD.CustomerMessage);

            crudRepo.AddToList(newCRUD);    // add to the list
            
        }

        // update method 
        public void CustUpdate()
        {
            Console.WriteLine("Enter first name\n");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter last name\n");
            string lName = Console.ReadLine();

            CRUD updatedCustomer = crudRepo.CustUpdae(fName, lName);
            Console.WriteLine("Enter new cust fName ");
            updatedCustomer.CustomerFirstName = Console.ReadLine();
            Console.WriteLine("Enter new cust lName ");
            updatedCustomer.CustomerLastName = Console.ReadLine();
        }

        // display all and their messages
        public void DisplayAll()
        {
            List<CRUD> listCRUD = crudRepo.GetCustomers();
            {
                foreach (CRUD item in listCRUD)
                {
                    Console.WriteLine($"Customer ID: {item.CustomerID}\n Customer FirstName: {item.CustomerFirstName}\n Customer LastName: {item.CustomerLastName}\n Customer Message: {item.CustomerMessage}");
                } Console.ReadLine();
            }
        }
        // delete 
        private void RemoveFromListBySpecification()
        {
            // Show all listed first!
            DisplayAll();
            Console.WriteLine("Please type the customer number you want to delete:\n");
            int customerNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type the customer last name you want to delete:\n");
            string custLname = Console.ReadLine();

            bool success = crudRepo.DeleteCust(customerNo, custLname);
            if (success == true)
            {
                Console.WriteLine($"\n  Successfully Removed From List " +
                "\n---Please hit enter to continue!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\n Sorry, we are unable to remove {customerNo}, customer No. {custLname} from List ");
                Console.ReadKey();
            }
        }
    }
}