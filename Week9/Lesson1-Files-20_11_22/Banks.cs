using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class Banks : BankEx3
    {
       public Banks(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone) : base(bankCode, bankName, branchCode, branchAddress, city, telephone) { }
       
    }
}
