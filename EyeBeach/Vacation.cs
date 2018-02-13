using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeBeach
{
    public class Vacation : Travel
    {
        //fields
        //invisible

        //Properties
        //inherited only

        //Constructors
        public Vacation()
        {
            //default constructor
        }
        
        public Vacation(string eyeColor)
        {
            EyeColor = eyeColor;
        }

        //Methods
        public override int EyeNumber()
        {

            if (EyeColor == "HAZEL")
            {
                return 1;
            }
            if (EyeColor == "BROWN")
            {
                return 2;
            }
            if (EyeColor == "BLUE")
            {
                return 3;
            }
            if (EyeColor == "GREEN")
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public void Beaches()
        {
         switch (EyeNumber())
            {
                case 1:
                    Console.WriteLine("Waikiki");
                    break;
                case 2:
                    Console.WriteLine("Venice Beach");
                    break;
                case 3:
                    Console.WriteLine("Rehobeth");
                    break;
                case 4:
                    Console.WriteLine("Redondo Beach");
                    break;
                default:
                    Console.WriteLine("Edgewater");
                    break;
            }
        }

        
    }
}
