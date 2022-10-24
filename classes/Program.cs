using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyCar = new Car();
            {

                MyCar.Make = "Ford";
                MyCar.Model = "F150";
                MyCar.Year = 2020;
            }


            Console.WriteLine($"{MyCar.Make},{MyCar.Model},{MyCar.Year}");
            

        }
    }
}

