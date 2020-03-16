using System;

namespace counting nonrepeating characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka;
            bool Proverka = false;
            int Simvol = 0;
            Console.Write("Введите строку: ");
            stroka = Console.ReadLine();
            Console.WriteLine(stroka);
            for (int i = 0; i < stroka.Length; i++)
            {
                for (int j = 0; j < stroka.Length; j++)
                {
                    if (i != j)
                    {
                        if (stroka[i] == stroka[j])
                        {
                            Proverka = true;
                        }
                        if ((j == stroka.Length - 1) && (Proverka == false))
                        {
                            Simvol++;
                        }
                    }
                }
                Proverka = false;
            }
            Console.WriteLine("Неповторяющихся символов " + Convert.ToString(Simvol));

        }
    }
}
