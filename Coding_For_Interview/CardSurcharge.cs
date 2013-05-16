using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_For_Interview
{
    public class CardSurcharge
    {
        public static decimal GetSurcharge(string cardType, decimal initialAmount)
        {
            decimal surchargeAmount = 0.00m;

            switch (cardType)
            {
                case "Amex":
                    surchargeAmount = initialAmount * 3.1m / 100;
                    break;
                case "MasterCard":
                    if (initialAmount <= 100) surchargeAmount = initialAmount * 1.2m / 100; else surchargeAmount = initialAmount * 1.0m / 100;
                    break;
                case "Visa":
                    surchargeAmount = initialAmount * 1.0m / 100;
                    break;
                default:
                    surchargeAmount = 0.40m;
                    break;
            }


            return surchargeAmount;

        }
    }
}
