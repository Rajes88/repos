using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] DaysofTheweek = { "SAT", "SUN", "MON", "TUE","WED", "THU", "FRI"};
            string[] arrayweek = new string[7];

            Console.WriteLine(DaysofTheweek.Length.ToString());

            for (int ival = 0; ival <DaysofTheweek.Length; ival++)
            {

                Console.WriteLine(DaysofTheweek[ival]);

            }
        }
    }

}
