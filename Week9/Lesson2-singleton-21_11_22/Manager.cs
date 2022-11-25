using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9.Lesson2_21_11_22
{
    internal class Manager
    {
        private Manager() { }

        private readonly static Manager _INSTANCE = new Manager();

        public static Manager INSTANCE
        {
            get 
            {
                return _INSTANCE;
            }
        }

        private Bank[] Load()
        {
            StreamReader sr = new StreamReader(fileName);
            Bank[] bank = new Bank[CountLines()];
            sr = new StreamReader(fileName);
            int index = 0;
            sr.ReadLine();
            while (sr.ReadLine() is string str)
            {
                string[] bankDetails = str.Split(',');

                bank[index] = new Bank(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                index++;
            }
            sr.Close();
            return bank;
        }

        private const string fileName = @"C:\Users\97252\source\repos\Week9\Week9\bin\Debug\snifim.txt";
        private int CountLines()
        {
            StreamReader sr = new StreamReader(fileName);
            int countLines = 0;
            while (sr.ReadLine() is string str)
            {
                countLines++;
            }
            sr.Close();
            return countLines;
        }

        public Bank GetBranchInfo(string BankCode, string BranchCode)
        {
            Bank[] banklist = Load();

            for (int i = 0; i < banklist.Length; i++)
            {
                if (banklist[i].BankCode.Contains(BankCode) && banklist[i].BranchCode.Contains(BranchCode))
                {
                    return banklist[i];
                }
            }

            Console.WriteLine("Invalid input");
            return null;
        }
    }
}



