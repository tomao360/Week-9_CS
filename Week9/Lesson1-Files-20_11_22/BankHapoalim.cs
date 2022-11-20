using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class BankHapoalim : BankEx3
    {
        public BankHapoalim(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone) : base(bankCode, bankName, branchCode, branchAddress, city, telephone) { }

        private int _workersInSnif;
        public int WorkersInSnif
        {
            get { return _workersInSnif; }

            set
            { 
                if (_workersInSnif == 0)
                {
                    _workersInSnif = value;
                }
            }
        }
    }

    internal class BankHapoalim2
    {
        public BankHapoalim2(int branchNum)
        {
            NUMBER_OF_BRANCHES = branchNum;
            bankHapoalimList = new BankHapoalim[NUMBER_OF_BRANCHES];
        }

        public readonly int NUMBER_OF_BRANCHES;

        BankHapoalim[] bankHapoalimList;

        int index = 0;
        public void Import(BankEx3[]list)
        {
            for (int i = 0; i < list.Length -1; i++)
            {
                if (list[i] is BankHapoalim)
                {
                    BankHapoalim bankHapoalim = (BankHapoalim)list[i];
                    bankHapoalimList[index] = bankHapoalim;
                    index++;
                }   
            }
        }

        public void Print()
        {
            for (int i = 0; i < bankHapoalimList.Length; i++)
            {
                Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}, Workers In Snif:{6}", bankHapoalimList[i].BankCode, bankHapoalimList[i].BankName, bankHapoalimList[i].BranchCode, bankHapoalimList[i].BranchAddress, bankHapoalimList[i].City, bankHapoalimList[i].Telephone, bankHapoalimList[i].WorkersInSnif);
            }
        }
    }
}
