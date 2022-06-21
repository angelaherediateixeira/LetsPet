using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Employees
{
    public class BankInfo
    {
        private string Bank { get; set; }

        private string Agency { get; set; }

        private string AccountNumber { get; set; }

        private string PixType { get; set; }

        private string Pix { get; set; }


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
