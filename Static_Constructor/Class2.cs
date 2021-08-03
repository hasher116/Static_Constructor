using System;

namespace Static_Constructor
{
    class Class2
    {
        int retirementAge = 60;
        public static void ChangeRetirementAge(int years)
        {
            //retirementAge += years;
        }
        public void DisplayRetirementAge()
        {
            Console.WriteLine(retirementAge);
        }
    }
}
