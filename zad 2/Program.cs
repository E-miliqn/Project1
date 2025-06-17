
namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Въведете число B: ");
            int B = int.Parse(Console.ReadLine());
            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }

            List<int> oddNumbers = new List<int>();
            for (int i = A; i <= B; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ", oddNumbers));
        }
    }
}
