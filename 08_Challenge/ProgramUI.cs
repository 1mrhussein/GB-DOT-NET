using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    class ProgramUI
    {
        public void Run()
        {
            SmartInsurance si = new SmartInsurance();

            Console.WriteLine("-----------Hi and welcome------------");

            Console.WriteLine("Did you follow closely when driving? Please type true for Yes and false for No:  \n");
            si.CloseFollow = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Did you swerve out when driving? Please type true for Yes and false for No:  \n");
            si.SwerveOut = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Did you roll through when driving? Please type true for Yes and false for No:  \n");
            si.RollingThrough = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Did you speed when driving? Please type true for Yes and false for No:  \n\n");
            si.AboveSpeed = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"Based on your information, your premium will be: ${si.PremiumCalc()}");
            Console.ReadKey();
        }
    }
}
