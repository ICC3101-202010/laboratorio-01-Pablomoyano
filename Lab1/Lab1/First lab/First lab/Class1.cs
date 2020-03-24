using System;
using System.Collections.Generic;
using System.Text;

namespace First_lab
{
    public class Person
    {
        public string name;
        public string lastname;
        public Person() 
        { name = "Bob";
            lastname = "Kunga";       }

        public void Lanza()
            {Random rdnum = new Random();
             int rn = rdnum.Next(0,3);
            if (rn == 0)
            { Console.WriteLine("Ha lanzado piedra"); }
            else if (rn == 1)
            { Console.WriteLine("Ha lanzado papel"); }
            else
            { Console.WriteLine("Ha lanzado tijera"); }

            }

    }
}
