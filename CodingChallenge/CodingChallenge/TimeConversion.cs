using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class TimeConversion
    {
        public static void Main(string[] args)
        {


            string time = "12:01:00PM";

            // To get AM or PM
            var amOrPm = time.Substring(8);

            // To get the hour part
            var hourComponent = time.Substring(0, 2);

            // To get the remaining part after hour part as it remains same in military time.
            var remainingTimeComponent = time.Substring(2, 6);

            // Only if hour is 12 then hour component needs to be set to 12 if its AM
            if (string.Equals(amOrPm, "AM") && Convert.ToInt32(hourComponent) == 12)
            {
                hourComponent = "00";
            }
            else if (string.Equals(amOrPm, "PM"))
            {
                var numericHourComponent = int.Parse(hourComponent);
                if (numericHourComponent != 12)
                {
                    hourComponent = Convert.ToString(numericHourComponent + 12);
                }
            }
            Console.WriteLine(hourComponent + remainingTimeComponent);

        }
    }
}
