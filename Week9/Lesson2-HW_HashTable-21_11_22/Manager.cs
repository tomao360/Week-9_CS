using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week9.Lesson2_HW_21_11_22
{
    internal class Manager
    {
        //Constructor
        private Manager() { }
        

        private readonly static Manager _INSTANCE = new Manager();
        public static Manager INSTANCE
        {
            get { return _INSTANCE; }
        }

        Hashtable tbl = new Hashtable();

        public void LoadTable()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i < 1000; i++)
            {
                int randomNum = random.Next(100, 10000);
                if (randomNum % 2 == 0)
                {
                    Falafel yossi = new Falafel(randomNum);
                    yossi.numFalafelBalls = random.Next(1, 6);

                    if (!(tbl[yossi.Id] is Falafel))
                    {
                        tbl.Add(yossi.Id, yossi);
                    }
                    else
                    {
                        // Console.WriteLine("The Id already exsit");
                    }
                }
                else
                {
                    IceCream Golda = new IceCream(randomNum);
                    Golda.numIceCreamBalls = random.Next(1, 6);

                    if (!(tbl[Golda.Id] is IceCream))
                    {
                        tbl.Add(Golda.Id, Golda);
                    }
                    else
                    {
                        //Console.WriteLine("The Id already exsit");
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Please enter a number between 100 to 9999");
                string numUser = Console.ReadLine();
                int userResponse = int.Parse(numUser);

                if (tbl[userResponse] is Falafel)
                {
                    Console.WriteLine($"This Falafel has {((Falafel)tbl[userResponse]).numFalafelBalls}");
                }
                else if (tbl[userResponse] is IceCream)
                {
                    Console.WriteLine($"This Ice Cream has {((IceCream)tbl[userResponse]).numIceCreamBalls}");
                }
                else
                {
                    Console.WriteLine("There is no such number in the HashTable");
                }
            }
        }
    }
}
