using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_reilly_Learning___1
{
    public class CelciusToFarenheit
    {
        public static void run()
        {
            Console.WriteLine("Enter the temp in Celcius");
            string input = Console.ReadLine()!;
            bool success = double.TryParse(input, out double celcius);

            if (success)
            {
                Console.WriteLine($"{celcius} C = " + ((celcius * 9 / 5) + 32) + " Farenheit");
            }
        }
    }
}
