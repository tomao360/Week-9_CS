using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class RunBankEx3
    {
        
        const string fileName = @"C:\Users\97252\source\repos\Week9\Week9\bin\Debug\snifim.txt";
        StreamReader sr = new StreamReader(fileName);
        public int CountLines()
        {
            int countLines = 0;
            while (sr.ReadLine() is string str)
            {
                countLines++;
            }
            sr.Close();
            return countLines;
        }
        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           
            StreamReader sr = new StreamReader(fileName);

            int CountLines()
            {
                int countLines = 0;
                while (sr.ReadLine() is string str)
                {
                    countLines++;
                }
                sr.Close();
                return countLines;
            }

            BankEx3[] bankEx3s = new BankEx3[CountLines()];

            sr = new StreamReader(fileName);
            int index = 0;
            sr.ReadLine();
            while (sr.ReadLine() is string str)
            {
                string[] bankDetails = str.Split(',');

                bankEx3s[index] = new BankEx3(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                index++;
            }
            sr.Close();


            for (int i = 0; i < bankEx3s.Length - 1; i++)
            {
                if (bankEx3s[i].City.Equals("ירושלים") || bankEx3s[i].City.Equals("תל אביב -יפו"))
                {
                    Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}", bankEx3s[i].BankCode, bankEx3s[i].BankName, bankEx3s[i].BranchCode, bankEx3s[i].BranchAddress, bankEx3s[i].City, bankEx3s[i].Telephone);
                }
            }

            Console.WriteLine("************");

            for (int i = 0; i < bankEx3s.Length - 1; i++)
            {
                if (bankEx3s[i].BankName.Contains("הפועלים") && bankEx3s[i].Telephone.Contains("8"))
                {
                    Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}", bankEx3s[i].BankCode, bankEx3s[i].BankName, bankEx3s[i].BranchCode, bankEx3s[i].BranchAddress, bankEx3s[i].City, bankEx3s[i].Telephone);
                }
            }

            Console.WriteLine("************");

            int counterMizrahi = 0;   
            for (int i = 0; i < bankEx3s.Length - 1; i++)
            {
                if (bankEx3s[i].BankName.Contains("מזרחי"))
                {
                    counterMizrahi++;
                }
            }

            Console.WriteLine($"The number of the Mizrahi Bank is: {counterMizrahi}");
        }

        public void Run2()
        {
            BankEx3[] bankEx3_2 = new BankEx3[CountLines()];
            StreamReader sr = new StreamReader(fileName);

            int index = 0;
            sr.ReadLine();
            while (sr.ReadLine() is string str)
            {
                string[] bankDetails = str.Split(',');

                if (bankDetails[1].Contains("הפועלים"))
                {

                    BankHapoalim bankHapoalim = new BankHapoalim(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                    bankHapoalim.WorkersInSnif = index;

                    bankEx3_2[index] = bankHapoalim;

                }
                else if (bankDetails[1].Contains("מזרחי"))
                {
                    BankMizrahi bankMizrahi = new BankMizrahi(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                    bankMizrahi.ClubMembersCount = index;

                    bankEx3_2[index] = bankMizrahi;
                }
                else if (bankDetails[1].Contains("לאומי"))
                {
                    BankLeomi bankLeomi = new BankLeomi(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                    bankLeomi.GiftForNewCustomers = "Gift Card";

                    bankEx3_2[index] = bankLeomi;
                }
                else if (bankDetails[1].Contains("דיסקונט"))
                {
                    BankDiscont bankDiscont = new BankDiscont(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);
                    bankDiscont.IsTeacher = true;

                    bankEx3_2[index] = bankDiscont;
                }
                else
                {
                    Banks banks = new Banks(bankDetails[0], bankDetails[1], bankDetails[2], bankDetails[4], bankDetails[5], bankDetails[8]);

                    bankEx3_2[index] = banks;
                }

                index++;
            }
            sr.Close();




            int counterHapoalim = 0;
            int counterDiscont = 0;

            for (int i = 0; i < bankEx3_2.Length - 1; i++)
            {
                if (bankEx3_2[i].BankName.Contains("הפועלים"))
                {
                    counterHapoalim++;
                }
            }

            
            for (int i = 0; i < bankEx3_2.Length - 1; i++)
            {
                if (bankEx3_2[i].BankName.Contains("דיסקונט"))
                {
                    counterDiscont++;
                }
            }


            BankHapoalim[] bankHapoalims = new BankHapoalim[counterHapoalim]; 
            int indexPoalim = 0;
            BankDiscont[] bankDisconts = new BankDiscont[counterDiscont];
            int indexDiscont = 0;

            for (int i = 0; i < bankEx3_2.Length; i++)
            {
                if (bankEx3_2[i] is BankHapoalim)
                {
                    BankHapoalim  bankHapoalim = (BankHapoalim)bankEx3_2[i];
                    bankHapoalims[indexPoalim] = bankHapoalim;

                   // Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}, Workers In Snif:{6}", bankHapoalims[indexPoalim].BankCode, bankHapoalims[indexPoalim].BankName, bankHapoalims[indexPoalim].BranchCode, bankHapoalims[indexPoalim].BranchAddress, bankHapoalims[indexPoalim].City, bankHapoalims[indexPoalim].Telephone, bankHapoalims[indexPoalim].WorkersInSnif);
                }
                else if(bankEx3_2[i] is BankDiscont)
                {
                    BankDiscont bankDiscont = (BankDiscont)bankEx3_2[i];
                    bankDisconts[indexDiscont] = bankDiscont;

                   // Console.WriteLine("Bank Code:{0}, Bank Name:{1}, Branch Code:{2}, Branch Address:{3}, City:{4}, Telephone:{5}, Is Teacher:{6}", bankDisconts[indexDiscont].BankCode, bankDisconts[indexDiscont].BankName, bankDisconts[indexDiscont].BranchCode, bankDisconts[indexDiscont].BranchAddress, bankDisconts[indexDiscont].City, bankDisconts[indexDiscont].Telephone, bankDisconts[indexDiscont].IsTeacher);
                }
            }

            BankHapoalim2 bankHapoalim2 = new BankHapoalim2(counterHapoalim);
            bankHapoalim2.Import(bankEx3_2);
            bankHapoalim2.Print();

            Console.WriteLine("************");

            BankDiscont2 bankDiscont2 = new BankDiscont2(counterDiscont);
            bankDiscont2.Import(bankEx3_2);
            bankDiscont2.Print();
        }
    }


    internal class BankEx3
    {
        const string fileName = @"C:\Users\97252\source\repos\Week9\Week9\bin\Debug\snifim.txt";
        public BankEx3(string bankCode, string bankName, string branchCode, string branchAddress, string city, string telephone)
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
