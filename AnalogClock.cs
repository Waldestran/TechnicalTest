using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class AnalogClock
    {
        int minute = 0;
        int hour = 0;
        int angle = 0;

        public void PrintText()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------- Analog Clock Option -------------------------------");
            Console.WriteLine("The following Analog Clock return the inner angle between clockwise in the relog hands");
            Console.Write("Enter hour = ");
            hour = int.Parse(Console.ReadLine());
            Console.Write("Enter minute = ");
            minute = int.Parse(Console.ReadLine());
        }

        public int CalculateAngleRight()
        {
            int diffInMinutes = 0;

            if(minute > (hour*5))
                diffInMinutes = Math.Abs((hour * 5) - minute);
            else
                diffInMinutes = 60 - ((hour * 5) - minute); //total of minutes = 60

            angle = diffInMinutes * 6; // 1 minute = 6 grades
            return angle;
        }

        public int CalculateAngleLefth()
        {
            int diffInMinutes = 0;

            if (minute < (hour * 5))
                diffInMinutes = (hour * 5) - minute;
            else
                diffInMinutes = 60 - Math.Abs(((hour * 5) - minute)); //total of minutes = 60

            angle = diffInMinutes * 6; // 1 minute = 6 grades
            return angle;
        }
    }
}
