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
        private string eyeColor;
        private int eyeNumber;
       

        //Properties
        public string EyeColor { get; set; }
        public int EyeNumber { get; set; }
       
        

        //Constructors
        public Travel()
        {
            //default constructor
        }

        //Methods
        public virtual int EyeToNumber()
        {

            if (EyeColor == "HAZEL")
            {
                return eyeNumber = 1;
            }
            if (EyeColor == "BROWN")
            {
                return eyeNumber = 2;
            }
            if (EyeColor == "BLUE")
            {
                return eyeNumber = 3;
            }
            if (EyeColor == "GREEN")
            {
                return eyeNumber = 4;
            }
            else
            {
                return eyeNumber = 5;
            }
        }
       

    }
}
