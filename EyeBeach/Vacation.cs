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

        public string Beach { get; set; }

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

        public virtual string Beaches(int eyeNumber)
        {
         switch (eyeNumber)
            {
                case 1:
                    return Beach = "Waikiki";
                case 2:
                    return Beach = "Venice Beach";
                case 3:
                    return Beach = "Rehobeth";
                case 4:
                    return Beach = "Redondo Beach";
                default:
                    return Beach = "Edgewater";
            }
        }

        
    }
}
