
namespace HomeWorks
{
    class Program
    {
        static public void Task2()
        {
            int numOne = 0, numTwo = 0;

            Console.WriteLine("Введите первое число: ");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите воторое число: ");
            numTwo = Convert.ToInt32(Console.ReadLine());

            if (numOne > numTwo)
            {
                Console.WriteLine($"Первое число {numOne} больше второго {numTwo}");
            }
            else if (numOne < numTwo)
            {
                Console.WriteLine($"Второе число {numTwo} больше первого {numOne}");
            }
            else if (numOne == numTwo)
            {
                Console.WriteLine($"Числа равны: ({numOne} == {numTwo})");
            }
            else
            {
                Console.WriteLine("Вообще не понимаю, что происходит =)");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("================= Задача №2 =================");
            Task2();
        }
    }
}
