using System;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ведите чысло от 4 до 8");
                Tiket();
            }


        }
        public static int Tiket()
        {
            while (true)
            {
                int value = 0;
                string s = Console.ReadLine().Trim();
                if (s.Length >= 4 && s.Length <= 8)
                {
                    if (int.TryParse(s, out value))
                    {
                        if (s.Length % 2 != 0)
                        {
                            s = "0" + s;
                        }
                        FirstSumTiketa(s);
                        SecondSumTiketa(s);
                        SecondSumTiketa(s);
                        Message(s);
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели не число");
                    }
                }
                else
                {
                    Console.WriteLine("Количество цифр должно быть от {0} до {1}", 4, 8);
                }
            }
        }
        public static int FirstSumTiketa(string tiket)
        {
            int sum = 0;
            for (int i = 0; i < tiket.Length / 2; i++)
            {
                sum += tiket[i];
            }
            return sum;
        }
        public static int SecondSumTiketa(string tiket)
        {
            int sum = 0;

            for (int i = tiket.Length / 2; i < tiket.Length; i++)
            {
                sum += tiket[i];
            }
            return sum;

        }
        public static void Message(string tiket)
        {
            if (FirstSumTiketa(tiket) == SecondSumTiketa(tiket))
            {
                Console.WriteLine("Квиток щасливий");
            }
            else { Console.WriteLine("Квиток не щасливий"); }
        }
    }
}
