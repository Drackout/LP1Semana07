using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color cc1 = new Color(225,29,111,255);

            Console.WriteLine(cc1.Red);
            Console.WriteLine(cc1.Green);
            Console.WriteLine(cc1.Blue);
            Console.WriteLine(cc1.Alpha);
            Console.WriteLine(cc1.GetColor);
            Console.WriteLine(cc1.GetGray);

        }
    }
}
