using System;
using System.Globalization;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string dateTimeString = Console.ReadLine();
            if (!DateTime.TryParseExact(
                dateTimeString,
                "M/d/yyy HH:mm",
                new CultureInfo("en-US"),
                DateTimeStyles.None,
                out DateTime dateTime))
            {
                dateTime = DateTime.Now;
            }
            */

            /*
            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.S: // Pressed S
                break;
                case ConsoleKey.F1: // Pressed F1
                break;
                case ConsoleKey.Escape: // Pressed Escape
                break;
            }
            */

            /*
            string tableNumber = "A100";
            int peopleCount = 4;
            DateTime reservationDateTime = new DateTime(
                2017, 10, 28, 11, 0, 0);
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Console.WriteLine(
                "Table {0} has been booked for {1} people on {2} at {3}",
                tableNumber,
                peopleCount,
                reservationDateTime.ToString("M/d/yyy", cultureInfo),
                reservationDateTime.ToString("HH:mm", cultureInfo));
            */

            CultureInfo cultureInfo = new CultureInfo("en-US");
            Console.Write("The table number: ");
            string table = Console.ReadLine();

            Console.Write("The number of people: ");
            string countString = Console.ReadLine();
            int.TryParse(countString, out int count);

            Console.Write("The reservation date (MM/dd/yyy): ");
            string dateTimeString = Console.ReadLine();
            if (!DateTime.TryParseExact(
                dateTimeString, 
                "M/d/yyy HH:mm",
                cultureInfo,
                DateTimeStyles.None,
                out DateTime dateTime))
            {
                dateTime = DateTime.Now;
            }

            Console.WriteLine("Table {0} has been booked for {1} people on {2} at {3}",
                table,
                countString,
                dateTime.ToString("M/d/yyy", cultureInfo),
                dateTime.ToString("HH:mm", cultureInfo));

        }
    }
}
