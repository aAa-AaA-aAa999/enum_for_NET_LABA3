using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string DayOfWeek = "nodata";
            string Time = "nodata";

            Console.WriteLine("Enter the number of the day of the week:");
            int numberDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hour:");
            int hour = Convert.ToInt32(Console.ReadLine());

            switch (numberDay)
            {
                case 1:
                    DayOfWeek = Convert.ToString(DayWeek.Monday);
                    break;
                case 2:
                    DayOfWeek = Convert.ToString(DayWeek.Tuesday);
                    break;
                case 3:
                    DayOfWeek = Convert.ToString(DayWeek.Wednesday);
                    break;
                case 4:
                    DayOfWeek = Convert.ToString(DayWeek.Thursday);
                    break;
                case 5:
                    DayOfWeek = Convert.ToString(DayWeek.Friday);
                    break;
                case 6:
                    DayOfWeek = Convert.ToString(DayWeek.Saturday);
                    break;
                case 7:
                    DayOfWeek = Convert.ToString(DayWeek.Sunday);
                    break;
                default: //если не будет совпадений
                    Console.WriteLine("There are only 7 days of the week.");
                    break;
            }

            if (hour >= 7 && hour <= 12) //от 7 до 12 - утро
            {
                Time = Convert.ToString(DayTime.Morning);
            }
            else if (hour >= 13 && hour <= 18) //от 13 до 18 - день
            {
                Time = Convert.ToString(DayTime.Afternoon);
            }
            else if (hour >= 19 && hour <= 23) //от 19 до 23 - вечер
            {
                Time = Convert.ToString(DayTime.Evening);
            }
            else if (hour >= 0 && hour <= 6) //от 0 до 6 - ночь
            {
                Time = Convert.ToString(DayTime.Night);
            }
            else
            {
                Console.WriteLine("There are only 24 hours in a day.");
            }

            Console.WriteLine($"It`s {DayOfWeek}, {Time}.");
            Console.ReadKey();
        }
        enum DayWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }
    
    }
}
