using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class BankDiscont : BankEx3
    {
        public BankDiscont(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone) : base(bankCode, bankName, branchCode, branchAddress, city, telephone) { }

        private bool _isTeacher;
        public bool IsTeacher
        {
            get { return _isTeacher; }
            set { _isTeacher = value; }
        }

    }

    internal class BankDiscont2
    {
        public BankDiscont2(int branchNum)
        {
            NUMBER_OF_BRANCHES = branchNum;
            bankDiscontList = new BankDiscont[NUMBER_OF_BRANCHES];
        }

        public readonly int NUMBER_OF_BRANCHES;

        BankDiscont[] bankDiscontList;

        int index = 0;
        public void Import(BankEx3[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[i] is BankDiscont)
                {
                    BankDiscont bankDiscont = (BankDiscont)list[i];
                    bankDiscontList[index] = bankDiscont;
                    index++;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < bankDiscontList.Length; i++)
            {
                Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}, Is Teacher:{6}", bankDiscontList[i].BankCode, bankDiscontList[i].BankName, bankDiscontList[i].BranchCode, bankDiscontList[i].BranchAddress, bankDiscontList[i].City, bankDiscontList[i].Telephone, bankDiscontList[i].IsTeacher);
            }
        }
    }
}

