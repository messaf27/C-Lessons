
namespace HomeWorks
{
    class Program
    {
        static public void Task2()
        {
            int numOne = 0, numTwo = 0;

            Console.WriteLine("================= Задача №2 =================");

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
        static public void Task4()
        {
            int numMaxIndex = 0;
            int[] numbers = new int[3];

            Console.WriteLine("================= Задача №4 =================");

            Console.Write("Введите первое число: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите воторое число: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 3; i++)
            {
                if(numbers[i] > numbers[numMaxIndex]) 
                    numMaxIndex = i;
            }

            Console.WriteLine($"БОльшее из трёх чисел это: {numbers[numMaxIndex]}");
        }
        static public void Task6()
        {
            int inputNum = 0, result = 0;

            Console.WriteLine("================= Задача №6 =================");

            Console.Write("Введите число: ");
            inputNum = Convert.ToInt32(Console.ReadLine());

            result = inputNum % 2;

            if(result > 0)
                Console.WriteLine($"Число {inputNum} - Нечётное");
            else
                Console.WriteLine($"Число {inputNum} - Чётное");
        }
        static public void Task8()
        {
            int inputNum = 0, result = 0, counter = 0;

            Console.WriteLine("================= Задача №8* =================");

            Console.Write("Введите число: ");
            inputNum = Convert.ToInt32(Console.ReadLine());

            if( inputNum % 2 > 0)
                Console.WriteLine($"Число {inputNum} не является чётным!!!");
            else
            {
                Console.Write($"Ряд четных чисел от 1 до {inputNum}: ");
                while(counter < inputNum)
                {
                    counter++;
                    result = counter % 2;
                    if(result == 0)
                    Console.Write($"{counter} "); 
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // Task2();
            // Task4();
            Task8();
        }
    }
}
