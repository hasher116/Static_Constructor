using System;

namespace Static_Constructor
{
    static class Class1
    {
        static Class1()
        {
            MinSum = 200;
            MaxSum = 2000;
        }
        public static int MinSum { get; private set; }
        public static int MaxSum { get; private set; }


        public static int GetSum(int sum)
        {
            if (sum < MinSum || sum > MaxSum)
            {
                Console.WriteLine("Ошибка");
                return 0;
            }
            return sum;
        }
        public static decimal GetRateSum(int sum, int rate, int period)
        {
            for (int i = 0; i < period; i++)
                sum = sum * rate / 100;
            return sum;
        }
    }
}
