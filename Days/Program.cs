using System;

namespace Days
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string userInput = Console.ReadLine();
            try
            {

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }

    public enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
