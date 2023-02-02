bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задачи: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 5: //Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
                {
                    // 1. Получить случайное число
                    // 1.1. Создать генератор случайных чисел
                    // 1.2. Задать промежуток в котором мы хотим получить случайное число
                    // 1.3. Получение случайного числа
                    // 2. Определить наибольшее цифру
                    // 2.1. Получить все цифры числа
                    // 2.1.1. Делим число по модулю на 10(процент, деление с получением остатка)
                    // 2.1.2. Делим число на 10 - сократили число до единиц
                    // 2.2. найти среди них самое большое
                    // 3. Вывести на экран полученное число

                    Random random = new Random(); // 1.1
                    int min = 10;
                    int max = 99; // 1.2 

                    int number = random.Next(min, max + 1); // 1.3

                    int a = number % 10; // 2.1.1.

                    int b = number / 10; // 2.1.2

                    if (a > b)
                    {
                        Console.WriteLine($"В числе {number} самая большая цифра {a}");
                    }
                    else
                    {
                        Console.WriteLine($"В числе {number} самая большая цифра {b}");
                    }

                    break;
                }
            case 6:
                {
                    Console.WriteLine("Введите число: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число: ");
                    int b = int.Parse(Console.ReadLine());

                    int result = a % b;
                    if (result == 0)
                    {
                        Console.WriteLine($"Число {b} кратно числу {a}");
                    }
                    else
                    {
                        Console.WriteLine($"Остаток от деления равен {result}");
                    }




                    break;
                }
            case 7:
                {
                    Console.WriteLine("Введите число: ");
                    int a = int.Parse(Console.ReadLine());
                    int b = 7;
                    int c = 23;

                    if (a % b == 0 && a % c == 0)
                    {
                        Console.WriteLine($"Число {a} кратно {b} и {c}");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} не кратно {b} или {c}");
                    }

                    break;
                }
            case 8: // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

                {
                    Console.WriteLine("Введите число: ");
                    int a, b;
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    if (b == Math.Pow(a, 2) || a == Math.Pow(b, 2))
                    {
                        Console.WriteLine("Да");
                    }
                    else
                    {
                        Console.WriteLine("Нет");
                    }
                }



                break;
        }






    }
}
