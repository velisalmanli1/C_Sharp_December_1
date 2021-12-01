using System;

namespace task_1
{
    class Program


    {
        static void Main(string[] args)

        {

            CarSpecifications Car1 = new CarSpecifications("Ford", "Ranger", 2021);


            Console.WriteLine($"{ Car1.brand} {Car1.model} {Car1.year}");
       

        }
    }
}
