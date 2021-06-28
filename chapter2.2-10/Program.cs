using System;

namespace chapter2._2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> noValue = new Nullable<int>();
            //Console.WriteLine(noValue.GetType());

            Nullable<int> someValue = new Nullable<int>(5);
            Console.WriteLine(someValue.GetType());
            Console.ReadKey();
        }
    }
}
