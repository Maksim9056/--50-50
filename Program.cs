using System.Reflection.Metadata;

namespace Компьютер_загадывает_число_от__50_до_50
{
    internal class Program
    {
        static void Main()
        {
            try { 

            Random random = new Random();
            int secretNumber = random.Next(-50, 51);

                while (true)
                {
                    Console.Write("Угадай число от -50 до 50: ");
                    string input = Console.ReadLine();

                    int userNumber;
                    if (!int.TryParse(input, out userNumber))
                    {
                        Console.WriteLine("Ошибка! Введено некорректное число.");
                        continue;
                    }

                    if (userNumber < -50 || userNumber > 50)
                    {
                        Main();
                        Console.WriteLine("Ошибка! Число должно быть в диапазоне от -50 до 50.");
                    }
                    else if (userNumber < secretNumber)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (userNumber > secretNumber)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляю! Ты угадал число!");
                        break;
                    }
                }

                Main();
                Console.ReadLine();
            }
            catch(ArgumentNullException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}