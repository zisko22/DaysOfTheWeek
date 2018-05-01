using System;

namespace Days
{
    class MainClass
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string userInput = Console.ReadLine();
                Week day = (Week)Convert.ToInt32(userInput);
                Console.WriteLine(day);
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
