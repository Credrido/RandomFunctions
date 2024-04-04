using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Event();
        }

        static void Event()
        {
            Key key = new Key("1");

            Computer c = new Computer();

            key.KeyPress += c.ReactToPressedKey;

            int counter = 10;

            while(Console.ReadKey().Key != ConsoleKey.O)
            {
                key.Press();
                if(counter-1 >= 5 )
                {
                    Console.WriteLine($"У тебя осталось {counter - 1} попыток");
                }
                if ((counter < 5) && (counter >2))
                {
                    Console.WriteLine($"У тебя осталось {counter - 1} попытки");
                }
                if (counter-1 == 1)
                {
                    Console.WriteLine($"У тебя осталось {counter - 1} попытка");
                }

                Console.WriteLine();

                counter--;

                if(counter == 0)
                {
                    Console.WriteLine("У тебя кончились попытки. Проиграл");

                    break;
                }
            }
            if(counter != 0)
            {
                Console.WriteLine(" правильная клавиша. Угадал");
            }
        }
    }
}