using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring data
            int num = 0, posc = 0;

            //Requesting data from the user
            Console.Write(" Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the posicion: ");
            posc = Convert.ToInt32(Console.ReadLine());

            int i = 1, move = 0;

            // Moving 1 to the given position
            move = i << (posc - 1);

            if ((num & move) == 0)
            {
                Console.WriteLine("The value of the bit in that position is 0");
            }
            else
            {
                Console.WriteLine("The value of the bit in that position is 1");
            }

            Console.ReadKey();      
       
        }
    }
}
