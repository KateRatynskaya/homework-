using System;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 2; i++)
            {
                Console.WriteLine("Число {0} в {1}- ой системе счисления равно: {2}", num, i, ConvertTo(num, i));
            }
            Console.ReadKey();
        }
        public static string ConvertTo(int i, int bases)
        {
            switch (bases)
            {
                case 2: return IntToString(i, new char[] { '0', '1' });
                    break;
               

                default: return bases + " system not define";

            }
        }
        public static string IntToString(int value, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;
            do
            {
                result = baseChars[value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);
            return result;
        }
    }
}

