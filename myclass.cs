using System;
using System.Collections.Generic;
using System.Text;

namespace programming101
{
    class myclass
    {
        public string home;

        float Sum(float x, float y)
        {
            return x + y;
        }

        void Print(string X)
        {
            Console.WriteLine(X);
        }

        public void Start()
        {
            Print("enter your name:");

            string myName = Console.ReadLine();

            Print("Hello, " + myName + "!");

            Print("how old r u?");

            string age = Console.ReadLine();

            Print("so you're" + age + ".");


            Print("type 1 if you livein lafayette, type 0 if not.");

            string livesinlafayette = Console.ReadLine();

            if (livesinlafayette == "0")
            {
                Print("where do you live?");

                home = Console.ReadLine();

            }
            else if (livesinlafayette == "1")
            {
                home = "lafayette";
            }
            else
            {
                Print("put in a valid answer");
            }


            Print("Ah, so you lvive in " + home + ".");

            Print("so let me get this straight you are " + age + " yrld " + myName + " and you live in " + home + ".");

            int x = 0;

            while (x < 10)
            {
                x = x + 1;
                Console.WriteLine(x);

                System.Threading.Thread.Sleep(250);
            }


        }

    }
}
