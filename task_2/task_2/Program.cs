using System;

namespace task_2
{
    class Program
    {

        // 2)Methoda musbet bir eded gelir,
        // hemin ededin faktorialinin hesablanmasi
        // algoritmi yazmaq (method ve class istifade etmekle).


        static void Main(string[] args)
        {
            int a = 7;
            int factorial = 1;
            for (int i =1; i <= a; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(a + "! =" + factorial);




        }
    }
}
