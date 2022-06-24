using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Employees
{
    public class BankInfo
    {
         public string Bank { get; private set; }
         public string Agency { get; private set; }
         public string AccountNumber { get; private set; }
         public string PixType { get; private set; }
         public string Pix { get; private set; }


        public BankInfo(string bank, string agency, string accountNumber, string pixType, string pix)
        {

            Bank = bank;
            Agency = agency;
            AccountNumber = accountNumber;
            PixType = pixType;
            Pix = pix;

        }



    }
}
