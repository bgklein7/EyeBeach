using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeBeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What color are your eyes?");
            Vacation vacation1 = new Vacation(Console.ReadLine().ToUpper());

            Console.WriteLine("What is your shoe size?");
            Hotel hotel1 = new Hotel(double.Parse(Console.ReadLine()));

            vacation1.EyeToNumber();
            hotel1.EyeToNumber();

            Console.WriteLine(vacation1.Beach + " " + hotel1.HotelName);

            
            

        }
    }
}
