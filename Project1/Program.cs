using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            int decimalNumber = 0;
            int power = 1;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '1')
                {
                    decimalNumber += power;
                }
                power *= 2;
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
