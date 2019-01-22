using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Program

    {
        static void Main(string[] args)           
        {
            Clemson Taylor = new Clemson();
            Taylor.Win = true;

            Alabama Tua = new Alabama();
            Tua.Win = false;
            if(Taylor.Win==true)
            {
                Console.WriteLine("Victory Clemson!");

                    }
            else
            { Console.WriteLine("Victory Alabama..");
            }
            Console.ReadLine();

        }
    }

}
  

