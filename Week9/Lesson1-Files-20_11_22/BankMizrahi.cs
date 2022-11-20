using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class BankMizrahi : BankEx3
    {
        public BankMizrahi(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone) : base(bankCode, bankName, branchCode, branchAddress, city, telephone) { }

        private int _clubMembersCount;
        public int ClubMembersCount
        {
            get { return _clubMembersCount; }
            set { _clubMembersCount = value; }
        }
    }
}
