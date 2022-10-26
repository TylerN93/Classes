using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            {

                myCar.Make = "Ford";
                myCar.Model = "F150";
                myCar.Year = 2020;
            }


            Console.WriteLine($"{myCar.Make},{myCar.Model},{myCar.Year}");
            

        }
    }
}

