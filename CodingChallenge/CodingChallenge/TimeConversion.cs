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


            string time = "01:01:00PM";
            var amOrPm = time.Substring(8);
            var hourComponent = time.Substring(0, 2);
            var remainingTimeComponent = time.Substring(2, 6);
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
