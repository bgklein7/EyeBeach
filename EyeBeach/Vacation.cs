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
        public double ShoeSize { get; set; }

        //Constructors
        public Vacation()
        {
            //default constructor
        }
        
        public Vacation(string eyeColor)
        {
            this.EyeColor = eyeColor;
        }

        //Methods
        public override int EyeToNumber()
        {
            int eyeNumber = base.EyeToNumber();  //base means run all code in base method but can make changes in override method without rewriting.
            Beaches(eyeNumber);
            return base.EyeToNumber();
        }

        public static void Beaches(int eyeNumber)
        {
         switch (eyeNumber)
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
