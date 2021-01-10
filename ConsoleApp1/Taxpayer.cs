using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Taxpayer
    {
        //Ushtrimi 2- Tema 2
        public int SocialSecurityNumber { get; set; }
        public int YearlyGrossIncome { get; set; }

        public readonly int TaxOwed;
        public Taxpayer(int income)
        {
            if(income < 30000)
            {
                TaxOwed = (15 * income) / 100;
            }
            else
            {
                TaxOwed = (28 * income) / 100;
            }
        }
    }
}
