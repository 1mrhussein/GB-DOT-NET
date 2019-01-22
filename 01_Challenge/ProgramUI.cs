using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge // KomodoCafe
{
    public class ProgramUI
    {
        MenuRepository _menuRepository = new MenuRepository();

        internal void Run()
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("\n\n ---------Hello Manager, Please Select a Choice!---------\n\n" +
                                                    "1.         Add    Menu: \n" +
                                                    "2.     Display    Menu\n" +
                                                    "3.      Delete    Menu:\n" +
                                                    "4.       Close    Program:\n");

                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        addToList();
                        break;
                    case 2:
                        Console.Clear();
                        displayList();
                        break;
                    case 3:
                        removeFromListBySpecification();
                        break;
                    case 4:
                        run = false; // close program
                        break;
                }
            }
        }

        private void addToList()
        {
            Menu _menu = new Menu();

            Console.Clear();
            Console.WriteLine("Please enter meal no");
            _menu.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter meal name");
            _menu.MealName = Console.ReadLine();

            Console.WriteLine("Please enter meal description");
            _menu.MealDescription = Console.ReadLine();

            Console.WriteLine("Please enter meal ingredients");
            _menu.MealIngredients = Console.ReadLine();

            Console.WriteLine("Please enter meal price");
            _menu.MealPrice = decimal.Parse(Console.ReadLine());
            //---------------------
            _menuRepository.addMenuToList(_menu);
        }

        private void displayList()
        {
            List<Menu> menuList = _menuRepository.getListedMenu();
            foreach (Menu content in menuList)
            {
                Console.WriteLine($"\n\n ---------Below is your menu list----For Meal No: {content.MealNumber}:\n\n" +
                    $" Meal No.: {content.MealNumber}\n Meal Name: {content.MealName}\n Meal Description: {content.MealDescription} \n Meal Ingredients: {content.MealIngredients}\n Meal Price: {content.MealPrice}");
            }
        }

        private void removeFromListBySpecification()
        {
            displayList();  // Show all listed menus first!

            Console.WriteLine("Please type the menu number you want to delete:\n");
            string input = Console.ReadLine();
            int mealNumber = int.Parse(input);

            Console.WriteLine("Please type the menu name you want to delete:\n");
            string mealName = Console.ReadLine();

            bool success = _menuRepository.RemoveBySpecification(mealName, mealNumber);
            if (success == true)
            {
                Console.WriteLine($"\n {mealName} Meal No. {mealNumber} Successfully Removed From List " +
                "\n---Please hit enter to continue!");
                DeletedSound();
                Run();
            }
            else
            {
                Console.WriteLine($"\n Sorry, we are unable to remove {mealName}, Meal No. {mealNumber} from List ");
                NotDeletedSound();
                Console.ReadKey();
            }
        }

        private void DeletedSound()
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = @"C:\Users\EDUCATION\source\repos\Sound\TADA.wav";
            myPlayer.Play();
            Console.ReadLine();
            Console.Clear();
            
        }

        private void NotDeletedSound()
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = @"C:\Users\EDUCATION\source\repos\Sound\UHOH.wav";
            myPlayer.Play();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
