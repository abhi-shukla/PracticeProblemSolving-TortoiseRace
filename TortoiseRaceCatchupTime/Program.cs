using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseRaceCatchupTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = GetTimeToCatchUp(720, 850, 70);
            Console.WriteLine("[ " + time[0] + ", " + time[1] + ", " + time[2] + " ]");

            time = GetTimeToCatchUpUsingTimeSpan(80, 91, 37);
            Console.WriteLine("[ " + time[0] + ", " + time[1] + ", " + time[2] + " ]");
            Console.ReadLine();
        }

        private static int[] GetTimeToCatchUp(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;
            int seconds = (int)((double)g / (v2 - v1) * 3600);
            return new int[] { seconds / 3600, seconds % 3600 / 60, seconds % 60 };
        }

        private static int[] GetTimeToCatchUpUsingTimeSpan(int v1, int v2, int g)
        {
            if (v1 >= v2) return null;
            var ts = System.TimeSpan.FromSeconds((g * 3600) / (v2 - v1));
            return new[] { ts.Hours, ts.Minutes, ts.Seconds };
        }
    }
}
