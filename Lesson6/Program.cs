
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

            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > numbers[numMaxIndex])
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

            if (result > 0)
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

            if (inputNum % 2 > 0)
                Console.WriteLine($"Число {inputNum} не является чётным!!!");
            else
            {
                Console.Write($"Ряд четных чисел от 1 до {inputNum}: ");
                while (counter < inputNum)
                {
                    counter++;
                    result = counter % 2;
                    if (result == 0)
                        Console.Write($"{counter} ");
                }
                Console.WriteLine();
            }
        }
        static public void Task10()
        {
            int inputNum = 0, remNum = 0;

            Console.WriteLine("================= Задача №10 =================");

            Console.Write("Введите трёхзначное число: ");
            inputNum = Convert.ToInt32(Console.ReadLine());

            if ((inputNum < 100) || (inputNum > 999))
            {
                Console.WriteLine($"Число {inputNum} не является трёхзначным!!!");
            }
            else
            {
                remNum = (inputNum % 100) / 10;
                Console.WriteLine($"Второе число: {remNum}");
            }
        }
        static public void Task13()
        {
            int inputNum = 0, remNum = 0, divNum = 0;

            Console.WriteLine("================= Задача №13 =================");

            Console.Write("Введите число: ");
            inputNum = Convert.ToInt32(Console.ReadLine());

            if ((inputNum < 100) && (inputNum > 0))
            {
                Console.WriteLine($"Число {inputNum} не трёхзначное!!!");
            }
            else
            if (inputNum == 0)
            {
                Console.WriteLine("Число должно быть больше нуля!!!");
            }
            else
            {
                divNum = 1;
                remNum = inputNum;

                int counter = 0;
                while (remNum > 0)
                {
                    counter++;
                    remNum = remNum / 10;

                    if(counter > 3)
                        divNum = 10 * divNum;
                }

                remNum = (inputNum / divNum) % 10;

                // Console.WriteLine($"Всего цыфр в числе: {counter}, делитель: {divNum}");
                Console.WriteLine($"Третье число: {remNum}");
            }
        }
        static public void Task15()
        {
            int inputNum = 0;

            Console.WriteLine("================= Задача №15 =================");

            Console.Write("Введите номер дня недели: ");
            inputNum = Convert.ToInt32(Console.ReadLine());

            if((inputNum > 7) || (inputNum < 1))
            {
                Console.WriteLine($"День недели должен быть от 1 до 7 ");
            }
            else
            if((inputNum > 5) && (inputNum < 8))
            {
                Console.WriteLine($"День недели №{inputNum} является ВЫХОДНЫМ днём!");
            }
            else
            {
                Console.WriteLine($"День недели №{inputNum} является РАБОЧИМ днём!");
            }
        }
        static public void Task19()
        {
            Console.WriteLine("================= Задача №19 =================");

            Console.Write("Проверка числа на палиндромом. Введите число: ");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            int reverseNum = 0, tempNum = 0;

            tempNum = inputValue;
            while(tempNum > 0) // (tempNum != 0) or (tempNum > 0)
            {
                reverseNum *= 10;
                reverseNum = reverseNum + tempNum % 10;
                tempNum = tempNum / 10; 
            }

            if(reverseNum == inputValue)
                Console.WriteLine($"Число {inputValue} является палиндромом.");
            else
                Console.WriteLine($"Число {inputValue} не является палиндромом.");
        }
        static void Main(string[] args)
        {
            // Task2();
            // Task4();
            // Task8();
            // Task10();
            // Task15();
            Task19();

        }
    }
}
