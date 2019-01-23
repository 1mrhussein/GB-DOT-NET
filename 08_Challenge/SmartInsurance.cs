using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    class SmartInsurance
    {
        private decimal Premium { get; set; }
        public bool CloseFollow { get; set; }
        public bool SwerveOut { get; set; }
        public bool RollingThrough { get; set; }
        public bool AboveSpeed { get; set; }

        public SmartInsurance(decimal aPremium, bool aCloseFollow, bool aSwerveOut, bool aRollingThrough, bool aAboveSpeed)
        {
            Premium = aPremium;
            SwerveOut = aSwerveOut;
            CloseFollow = aCloseFollow;
            RollingThrough = aRollingThrough;
            AboveSpeed = aAboveSpeed;
        }
        public decimal PremiumCalc()
        {
            decimal premium = 0m;
            // all false---which is good!
            if ((CloseFollow == false) && (SwerveOut == false) && (RollingThrough == false) && (AboveSpeed == false)) 
            {
                premium = 55.00m;
            }
            // all true----which is bad!
            else if ((CloseFollow == true)&& (SwerveOut == true ) && (RollingThrough == true) && (AboveSpeed == true)) 
            {
                premium = 55.00m * 2.00m;
            }
            // one false
           
            return premium;
        }
        public SmartInsurance()
        {
            //empty constructor
        }
    }
}