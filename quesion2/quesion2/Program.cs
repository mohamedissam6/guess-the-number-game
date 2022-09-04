using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;
          

            Random random = new Random();
            while (true)
            {
                x = random.Next(1, 1000);
                Console.WriteLine("guess the number (from 1 to 1000)");
                while (true) {
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y == x)
                    {
                        Console.WriteLine("Congratulation , you guessed the number!");
                        break;

                    }
                    else if (y > x) {
                        Console.WriteLine("Too high. try again");

                    }
                    else {
                        Console.WriteLine("Too law. try again");
                    }
                    
                }
               // Console.WriteLine("want to exit??, if yes type yes");
                
                //if (Console.ReadLine() == "yes") break;
            }
        }

       
    }
}
