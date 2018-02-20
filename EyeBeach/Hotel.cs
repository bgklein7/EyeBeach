using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeBeach 
{
    public class Hotel : Vacation
    {
        //fields
        //invisible

        //Properties
        //inherited only

        //Constructors
        public Hotel()
        {
            //default constructor
        }

        public Hotel(double shoeSize)
        {
            this.ShoeSize = shoeSize;
        }

        //Methods
        public void Hotels()
        {
            if(ShoeSize == 6.5)
            {
                Console.WriteLine("Hojo");
            }
            if(ShoeSize == 10.5)
            {
                Console.WriteLine("Waldorf Astoria");
            }
            else
            {
                Console.WriteLine("No-tell Motel");
            }
        }
    }

}
