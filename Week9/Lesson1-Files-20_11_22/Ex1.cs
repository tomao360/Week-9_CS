using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week9.Lesson1_Files_20_11_22
{
  
    internal class RunEx1
    {
        public void Run()
        {
            Ex1 ex1 = new Ex1();
            ex1.Write();
            ex1.Read();
        }
    }
    internal class Ex1
    {
        const string fileName = "Ex1.txt";
        public void Write()
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine("*****");
            sw.Close();
            sw = new StreamWriter(fileName, true);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("please enter a line to the file");
                string str = Console.ReadLine();
                sw.WriteLine(str);
            }
            sw.Close(); 
        }

        public void Read()
        {
           
            StreamReader sr = new StreamReader(fileName);
            int i = 1;
            while (sr.ReadLine() is string str)
            {
                Console.WriteLine("Line#{0}: {1}", i, str);
                i++;
            }
            sr.Close();
        }
    }
}
