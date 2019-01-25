using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class SmartInsurance
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
            // GA---The best which does not violate any rule!
            if ((CloseFollow == false) && (SwerveOut == false) && (RollingThrough == false) && (AboveSpeed == false)) 
            {
                premium = 55.00m;
            }
           // GF---The worst which violates all the rules!
            else if ((CloseFollow == true)&& (SwerveOut == true ) && (RollingThrough == true) && (AboveSpeed == true)) 
            {
                premium = 55.00m + 55.00m * 0.25m;
            }
            // G1
            else if ((CloseFollow == true) && (SwerveOut == true) && (RollingThrough == true) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.25m;
            }
            else if ((CloseFollow == true) && (SwerveOut == true) && (RollingThrough == false) && (AboveSpeed == true))
            {
                premium = 55.00m + 55.00m * 0.25m;
            }
            else if ((CloseFollow == true) && (SwerveOut == false) && (RollingThrough == true) && (AboveSpeed == true))
            {
                premium = 55.00m + 55.00m * 0.25m;
            }
            else if ((CloseFollow == false) && (SwerveOut == true) && (RollingThrough == true) && (AboveSpeed == true))
            {
                premium = 55.00m * 0.25m;
            }
            //G2
            else if ((CloseFollow == true) && (SwerveOut == true) && (RollingThrough == false) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.5m;
            }
            else if ((CloseFollow == true) && (SwerveOut == false) && (RollingThrough == true) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.5m;
            }
            else if ((CloseFollow == true) && (SwerveOut == false) && (RollingThrough == false) && (AboveSpeed == true))
            {
                premium = 55.00m + 55.00m * 0.5m;
            }
            else if ((CloseFollow == false) && (SwerveOut == true) && (RollingThrough == true) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.5m;
            }
            else if ((CloseFollow == false) && (SwerveOut == true) && (RollingThrough == false) && (AboveSpeed == true))
            {
                premium = 55.00m + 55.00m * 0.5m;
            }
            else if ((CloseFollow == false) && (SwerveOut == false) && (RollingThrough == true) && (AboveSpeed == true))
            {
                premium = 55.00m + 55.00m * 0.5m;
            }
            //G3
            else if ((CloseFollow == true) && (SwerveOut == false) && (RollingThrough == false) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.75m;
            }
            else if ((CloseFollow == false) && (SwerveOut == true) && (RollingThrough == false) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.75m;
            }
            else if ((CloseFollow == false) && (SwerveOut == false) && (RollingThrough == true) && (AboveSpeed == false))
            {
                premium = 55.00m + 55.00m * 0.75m;
            }
            else if ((CloseFollow == false) && (SwerveOut == false) && (RollingThrough == false) && (AboveSpeed == true))
            {
                premium = 55.00m + 55.00m * 0.75m;
            }

            return premium;
        }
        public SmartInsurance()
        {
            //empty constructor
        }
    }
}