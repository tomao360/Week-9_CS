using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class BankLeomi : BankEx3
    {
        public BankLeomi(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone) : base(bankCode, bankName, branchCode, branchAddress, city, telephone) { }

        private string _giftForNewCustomers;
        public string GiftForNewCustomers
        {
            get { return _giftForNewCustomers; }
            set { _giftForNewCustomers = value; }
        }


    }
}
