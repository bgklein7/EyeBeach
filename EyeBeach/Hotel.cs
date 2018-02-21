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
        public string HotelName { get; set; }
        public double ShoeSize { get; set; }

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
        public override string Beaches(int eyeNumber)
        {
            string beach = base.Beaches(eyeNumber);
            if(beach == "Waikiki" && ShoeSize == 6.5)
            {
                return HotelName = "HoJo";
            }
            if(beach == "Waikiki" && ShoeSize == 10.5)
            {
                return HotelName = "Waldorf Astoria";
            }
            if(beach == "Venice Beach" && ShoeSize == 6.5)
            {
                return HotelName = "Bates Motel";
            }
            if(beach == "Venice Beach" && ShoeSize == 10.5)
            {
                return HotelName = "Breakers";
            }
            if(beach == "Rehobeth" && ShoeSize == 6.5)
            {
                return HotelName = "Hilton";
            }
            if(beach == "Rehobeth" && ShoeSize == 10.5)
            {
                return HotelName = "Holiday Inn";
            }
            if(beach == "Redondo Beach" && ShoeSize == 6.5)
            {
                return HotelName = "Sheraton";
            }
            if(beach == "Redondo Beach" && ShoeSize == 10.5)
            {
                return HotelName = "Westin";
            }
            else
            {
                return HotelName = "No-tell Motel";
            }
        }
    }

}
