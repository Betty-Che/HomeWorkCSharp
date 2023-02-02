bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задачи: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1: //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
                {
                    Console.WriteLine("Введите значение a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение b: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int max = 0;
                    int min = 0;

                    if (a > b)
                    {
                        max = a;
                        min = b;
                    }
                    else
                    {
                        max = b;
                        min = a;
                    }
                    Console.WriteLine("max = " + max + " и " + "min = " + min);
                    break;
                }
            case 2: //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
                {
                    Console.WriteLine("Введите значение a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение c: ");
                    int c = Convert.ToInt32(Console.ReadLine());

                    if (a > b && a > c)
                    {
                        Console.WriteLine("Максимальное число:" + a);
                    }
                    else if (b > a && b > c)
                    {
                        Console.WriteLine("Максимальное число:" + b);
                    }
                    else if (c > a && c > b)
                    {
                        Console.WriteLine("Максимальное число:" + c);
                    }

                    break;
                }
            case 3: //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
                {
                    Console.WriteLine("Введите число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Четное");
                    }
                    else
                    {
                        Console.WriteLine("Нечетное");
                    }

                    break;
                }
            case 4: //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                {
                    Console.WriteLine("Введите число: ");
                    int a = Convert.ToInt32(Console.Read());
                    //int count = 2;

                    //while (count )

                    break;
                }
                break;
        }

    }
}
