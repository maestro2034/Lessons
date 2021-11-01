using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public class DaysConverter
    {
        public void GetDayFromInteger(int num)
        {
            switch (num)
            {
                case (int)Days.Sun: Console.WriteLine("Sun"); break;
                case (int)Days.Mon: Console.WriteLine("Mon"); break;
                case (int)Days.Tue: Console.WriteLine("Tue"); break;
                case (int)Days.Wed: Console.WriteLine("Wed"); break;
                case (int)Days.Th: Console.WriteLine("Th"); break;
                case (int)Days.Fr: Console.WriteLine("Fr"); break;
                case (int)Days.St: Console.WriteLine("St"); break;

                default:
                    ExtraManipulation(num);
                    break;
            }
        }
        //0, 1, 2, 3, 4, 5, 6
        //7, 8, 9, 10, 11, 12, 13
        private void ExtraManipulation(int num)
        {
            if (0 < num)
            {
                Console.WriteLine("Wrong date");
                return;
            }
            GetDayFromInteger(num - 7);
        }
    }
}
