using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeBeach
{
    public abstract class Travel
    {
        //fields
        //invisible

        //Properties
        public string EyeColor { get; set; }
        

        //Constructors
        public Travel()
        {
            //default constructor
        }

        //Methods
        public abstract int EyeNumber();
       

    }
}
