namespace DynamicArray_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            bool isWorking = true;
            List<int> numbers = new();

            while (isWorking)
            {
                Console.Clear();

                foreach (var number in numbers)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine($"\nВведите число или {CommandSum}, для суммирования введённых ранее чисел.");
                string userInput = Console.ReadLine();

                if (userInput == CommandSum)
                {
                    SumNumbers(numbers);
                }
                else if (userInput == CommandExit)
                {
                    isWorking = false;
                }
                else if (int.TryParse(userInput, out int number))
                {
                    numbers.Add(number);
                }

                Console.ReadKey();
            }
        }

        static void SumNumbers(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Сумма введенных ранее чисел: {sum}");
        }
    }
}
