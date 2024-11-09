using System;

namespace AdditionAndSubstraction
{
    namespace Addition
    {
        class Add
        {
            public void Print(int p, int q)
            {
                Console.WriteLine($"The value of p + q is {p + q}");
            }
        }
    }

    namespace Substraction
    {
        class Sub
        {
            public void Print(int p, int q)
            {
                Console.WriteLine($"The value of p - q is {p - q}");
            }
        }
    }
}

namespace MainNamespace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two values of p and q: ");
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            int p = Convert.ToInt32(values[0]);
            int q = Convert.ToInt32(values[1]);

            AdditionAndSubstraction.Addition.Add obj1 = new AdditionAndSubstraction.Addition.Add();
            obj1.Print(p, q);

            AdditionAndSubstraction.Substraction.Sub obj2 = new AdditionAndSubstraction.Substraction.Sub();
            obj2.Print(p, q);
        }
    }
}
