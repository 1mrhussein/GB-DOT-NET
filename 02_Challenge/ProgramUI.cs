using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    class ProgramUI
    {
        OutingsRepository _outingsRepository = new OutingsRepository();

        internal void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("---------Please select a choice:\n");
                Console.WriteLine("\t1. Display a list of all outings");
                Console.WriteLine("\t2. Add individual outings to a list");
                Console.WriteLine("\t3. To see the total cost of all outings");
                Console.WriteLine("\t4. To exit the program");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayOutingsFromList();
                        break;
                    case 2:
                        AddOutingsToList();
                        break;
                    case 3:
                        // Show total
                        break;
                    case 4:
                        running = false;
                        break;
                }
                break;
            }
        }

        public void AddOutingsToList()
        {
            Outings newOuting = new Outings();

            Console.Clear();
            Console.WriteLine("--------Hi, please choose the outing you want to add!\n");
            Console.WriteLine("\t1. Golf\n" +
                "\t2. Bowling\n" +
                "\t3. Amusement Park\n" +
                "\t4. Concert\n");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    newOuting.Type = TypeOfOutings.Golf;
                    break;
                case 2:
                    newOuting.Type = TypeOfOutings.Bowling;
                    break;
                case 3:
                    newOuting.Type = TypeOfOutings.AmusementPark;
                    break;
                case 4:
                    newOuting.Type = TypeOfOutings.Concert;
                    break;
            }
            Console.WriteLine("Pleae enter the cost per person:\n");
            newOuting.CostPerPerson = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter date of the event:\n");
            newOuting.EventDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please enter no of people to attend the event:\n");
            newOuting.NumberOfPeople = int.Parse(Console.ReadLine());

            newOuting.TotalCost = (newOuting.NumberOfPeople * newOuting.CostPerPerson); // Calc
            // add now to the list of the product 
            _outingsRepository.AddOutingToList(newOuting);

            Run();
        }
        
        public void DisplayOutingsFromList()
        {
            List<Outings> outingList = _outingsRepository.GetOutingList();
            foreach (Outings content in outingList)
            {
                Console.WriteLine($"Your Outing Type: {content.Type}\n Cost Per Person ${content.CostPerPerson} \n" +
                    $"Event Date: {content.EventDate} \n No of People: \t{content.NumberOfPeople} \n Total Cost: ${content.TotalCost}\n");
            }
        }
    }
}

// for testing purpose..
//Console.WriteLine("----------Welcome to the program!---------------\n");
//Console.ReadLine();