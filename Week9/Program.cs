using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Week9.Lesson1_Files_20_11_22;
using Week9.Lesson2_21_11_22;

namespace Week9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("windows-1255");

            RunEx1 runEx1 = new RunEx1();
            //runEx1.Run();

            RunEx2 runEx2 = new RunEx2();
            //runEx2.Run();

            RunBankEx3 runBankEx3 = new RunBankEx3();
            //runBankEx3.Run();

            RunBankEx3 runBankEx31 = new RunBankEx3();
            //runBankEx31.Run2();

            //Console.WriteLine("Please enter Bank Code: ");
            //string bankCode = Console.ReadLine();
            //Console.WriteLine("Please enter Branch Code: ");
            //string branchCode = Console.ReadLine();
            //Bank branch = Manager.INSTANCE.GetBranchInfo(bankCode, branchCode);
            //if (branch == null)
            //{
            //    Console.WriteLine("Couldnt find the branch");
            //}
            //else
            //{
            //    Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}", branch.BankCode, branch.BankName, branch.BranchCode, branch.BranchAddress, branch.City, branch.Telephone);
            //}

            Week9.Lesson2_HW_21_11_22.Manager.INSTANCE.LoadTable();

            Console.ReadLine();
        }
    }
}
