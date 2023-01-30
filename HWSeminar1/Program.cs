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
                    int max = a;

                    if (b > max)
                    {
                        max = b;
                    }
                    else
                    {
                        max = a;
                    }
                    if (c > max)
                    {
                        max = c;
                    }
                    else
                    {
                        max = a;
                    }

                    Console.WriteLine("max = " + max);
                    break;
                }
            case 3: //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
                {


                    break;
                }



        }
    }
}
