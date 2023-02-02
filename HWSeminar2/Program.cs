bool isWork = true;
while (isWork)
{
    Console.Write("Введите номер задачи: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1: //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
                {
                    Console.Write("Введите трехзначное число: ");
                    int number = int.Parse(Console.ReadLine());
                    int secondNum = number / 10 % 10;

                    Console.WriteLine($"{secondNum}");
                    break;
                }
            case 2: // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
                {
                    Console.Write("Введите трехзначное число: ");
                    int randomNum = int.Parse(Console.ReadLine());
                    int thirdNum = int.Parse(Console.ReadLine());

                    // if (num > 100)
                    // {

                    // }

                    if (randomNum < 100)
                    {
                        Console.WriteLine("Третьей цифры нет");
                    }
                    break;
                }
            case 3: //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
                {
                    Console.Write("Введите цифру дня недели: ");

                    if (int.TryParse(Console.ReadLine(), out int a))
                    {
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("понедельник");
                                break;
                            case 2:
                                Console.WriteLine("вторник");
                                break;
                            case 3:
                                Console.WriteLine("среда");
                                break;
                            case 4:
                                Console.WriteLine("четверг");
                                break;
                            case 5:
                                Console.WriteLine("пятница");
                                break;
                            case 6:
                                Console.WriteLine("суббота");
                                break;
                            case 7:
                                Console.WriteLine("воскресенье");
                                break;
                            default:
                                Console.WriteLine("Нет такого дня недели");
                                break;
                        }
                        if (a == 6 || a == 7)
                        {
                            Console.WriteLine("Это выходной");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Значение не найдено");
                    }


                    break;
                }
        }
    }
}