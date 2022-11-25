using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9.Lesson2_21_11_22
{
    internal class Bank
    {
        public Bank(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone)
        {
            BANK_CODE = bankCode;
            BankCode = BANK_CODE;
            BankName = bankName;
            BranchCode = branchCode;
            BranchAddress = branchAddress;
            City = city;
            Telephone = telephone;
        }

        public readonly string BANK_CODE;

        private string _bankCode;
        public string BankCode
        {
            get { return _bankCode; }
            set { _bankCode = value; }
        }

        private string _bankName;
        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        private string _branchCode;
        public string BranchCode
        {
            get { return _branchCode; }
            set { _branchCode = value; }
        }

        private string _branchAddress;
        public string BranchAddress
        {
            get { return _branchAddress; }
            set { _branchAddress = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _telephone;
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
    }
}

