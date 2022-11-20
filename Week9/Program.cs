using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week9.Lesson1_Files_20_11_22;

namespace Week9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunEx1 runEx1 = new RunEx1();
            //runEx1.Run();

            RunEx2 runEx2 = new RunEx2();
            //runEx2.Run();

            RunBankEx3 runBankEx3 = new RunBankEx3();
            //runBankEx3.Run();

            RunBankEx3 runBankEx31 = new RunBankEx3();
            runBankEx31.Run2();

            Console.ReadLine();
        }
    }
}
