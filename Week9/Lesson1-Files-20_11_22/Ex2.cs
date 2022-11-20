using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9.Lesson1_Files_20_11_22
{
    internal class RunEx2
    {
        public void Run()
        {
            Ex2 ex2 = new Ex2();
            ex2.Write();
            ex2.Read();
        }
    }
    internal class Ex2
    {
        const string fileName = "Ex2.txt";
        public void Write()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomNum = random.Next(50, 101);

            StreamWriter sw = new StreamWriter(fileName);
            for (int i = 0; i < randomNum; i++)
            {
                int randomNum2 = random.Next(3, 10);
                sw.WriteLine();
                for (int j = 0; j < randomNum2; j++)
                {
                    sw.Write("*");                   
                }
            }

            sw.Close();
        }    
        
        public void Read()
        {
            StreamReader sr = new StreamReader(fileName);
            while (sr.ReadLine() is string str)
            {
                Console.WriteLine(str);
            }

            sr.Close();
        }
    }
}
