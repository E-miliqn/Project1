namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя на учениците във втора група: ");
            int broiUchenici = int.Parse(Console.ReadLine());

            int broiSlabi = 0;
            int broiOtlichni = 0;

            for (int i = 1; i <= broiUchenici; i++)
            {
                Console.Write("Въведете оценка за ученик №" + i + ": ");
                int ocenka = int.Parse(Console.ReadLine());

                if (ocenka == 2)
                {
                    broiSlabi++;
                }
                else if (ocenka == 6)
                {
                    broiOtlichni++;
                }
            }

            Console.WriteLine("Слаб - " + broiSlabi + " оценки");
            Console.WriteLine("Отличен - " + broiOtlichni + " оценки");
        }
    }
}
