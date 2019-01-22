using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge // KomodoCafe
{
    public class MenuRepository
    {
        //add (List) object to our class Menu
        List<Menu> _menu = new List<Menu>();
        public void addMenuToList(Menu menu)
        {
            _menu.Add(menu);
        }
        // 
        public List<Menu> getListedMenu()
        {
            return _menu;
        }
        // Remove menu from list
        public void removeMenuListed(Menu menu)
        {
            _menu.Remove(menu);
        }
        // Remove by specification 
        public bool RemoveBySpecification(string mealName, int mealNumber)
        {
            bool success = false;
            foreach (Menu menu in _menu)
            {
                if (menu.MealName == mealName && menu.MealNumber == mealNumber)
                {
                    removeMenuListed(menu);
                    success = true;
                    break;
                }
            }
            return success;
        }
    }
}
