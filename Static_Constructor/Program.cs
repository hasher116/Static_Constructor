using System;

namespace Static_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.GetRateSum(1500, 40, 3));


            Class2 tom = new Class2();
            Class2.ChangeRetirementAge(5);
            tom.DisplayRetirementAge();
        }
    }
}
