bool isHomeWork = true;
while (isHomeWork)
{
    Console.Write("Введите номер задачи: ");
    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {

            case 1: //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

                {
                    Console.Write("Введите число: ");
                    string? number = Console.ReadLine();

                    void Number(string number)
                    {
                        if (number[0] == number[4] || number[1] == number[3])
                        {
                            Console.WriteLine($"{number} - палиндром.");
                        }
                        else Console.WriteLine($"{number} - НЕ палиндром.");
                    }

                    if (number!.Length == 5)
                    {
                        Number(number);
                    }
                    else Console.WriteLine($"Введи правильное число");

                }

                break;

            case 2: //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

                {
                    int x1 = PointCoordinate("x", "A");
                    int y1 = PointCoordinate("y", "A");
                    int z1 = PointCoordinate("z", "A");
                    int x2 = PointCoordinate("x", "B");
                    int y2 = PointCoordinate("y", "B");
                    int z2 = PointCoordinate("z", "B");

                    int PointCoordinate(string coordinateName, string pointName)
                    {
                        Console.Write($"Введите координату {coordinateName} точки {pointName}: ");
                        return Convert.ToInt16(Console.ReadLine());
                    }

                    double Result(double x1, double x2,
                                  double y1, double y2,
                                  double z1, double z2)
                    {
                        return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                                         Math.Pow((y2 - y1), 2) +
                                         Math.Pow((z2 - z1), 2));
                    }

                    double distanceLength = Math.Round(Result(x1, x2, y1, y2, z1, z2), 2);

                    Console.WriteLine($"Расстояние между точками =  {distanceLength}");

                }

                break;
            case 3: //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

                {
                    Console.Write("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    void N(int[] n)
                    {
                        int counter = 0;
                        int length = n.Length;
                        while (counter < length)
                        {
                            n[counter] = Convert.ToInt32(Math.Pow(counter, 3));
                            counter++;
                        }
                    }

                    void PrintArry(int[] coll)
                    {
                        int count = coll.Length;
                        int index = 0;
                        while (index < count)
                        {
                            Console.WriteLine(coll[index] + " ");
                            index++;
                        }
                    }

                    int[] arry = new int[n + 1];
                    N(arry);
                    PrintArry(arry);
                }

                break;
        }
    }
}