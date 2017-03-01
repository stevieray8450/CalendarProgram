using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDT = new DateTime(2017, 3, 1);
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            string currentMonth = myCal.GetMonth(myDT).ToString();
            string currentDay = myCal.GetDayOfMonth(myDT).ToString();
            string currentYear = myCal.GetYear(myDT).ToString();

            string currentDate = (currentMonth + "/" + currentDay + "/" + currentYear);
     

            Console.WriteLine(currentDate);
        }
    }
}
