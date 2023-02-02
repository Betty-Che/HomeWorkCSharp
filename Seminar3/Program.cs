// while (true)
// {
// 	Task1();
// }


// void Task1()
// {
// 	int x = ReadInt("X");
// 	int y = ReadInt("Y");

// 	int quarter = GetQuarter(x, y);

// 	Console.WriteLine($"{quarter}: [{x} - {y}]");
// }


// int GetQuarter(int x, int y)
// {
// 	if (x == 0 || y == 0)
// 	{
// 		return -1;
// 	}

// 	if (x > 0 && y > 0)
// 	{
// 		return 1;
// 	}
// 	else if (x < 0 && y > 0)
// 	{
// 		return 2;
// 	}
// 	else if (x < 0 && y < 0)
// 	{
// 		return 3;
// 	}
// 	else
// 	{
// 		return 4;
// 	}
// }

// int ReadInt(string argumentName)
// {
// 	Console.Write($"Input {argumentName}: ");

// 	int number = 0;
// 	while (!int.TryParse(Console.ReadLine(), out number))
// 	{
// 		Console.WriteLine("It's not a number");
// 	}

// 	return number;
// }

// while (true) // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// {
// 	Task1();
// }


// void Task1()
// {
// 	int number = ReadInt("quarter");
	
// 	string quarter = GetQuarter(number);

// 	Console.WriteLine($"{quarter}");
// }


// string GetQuarter(int quarter)
// {
// 	if (quarter == 1)
// 	{
// 		return "X От 1 до беконечности. Y от 1 до бесконечности";
// 	}

// 	else if (quarter == 2)
// 	{
// 		return "X От -1 до - беконечности. Y от 1 до бесконечности";
// 	}
// 	else if (quarter == 3)
// 	{
// 		return "X От -1 до - беконечности. Y от - 1 до - бесконечности";
// 	}
// 	else 
// 	{
// 		return "X От 1 до беконечности. Y от - 1 до - бесконечности";
// 	}
// }
// int ReadInt(string argumentName)
// {
// 	Console.Write($"Input {argumentName}: ");

// 	int number = 0;
// 	while (!int.TryParse(Console.ReadLine(), out number))
// 	{
// 		Console.WriteLine("It's not a number");
// 	}

// 	return number;
// }

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// while (true)
// {
//     Point p1 = new Point(1, 2);
//     Point p2 = new Point(3, 4); 
//     Console.WriteLine(p1.GetLegth(p2));
// }

// class Point 
// {
//     public int _x; 
//     public int _y;
//     public Point(int x, int y)
//     {
//         _x = x;
//         _y = y;

//     }

//     public double GetLegth(Point p)
//     {
//         return Math.Sqrt(Math.Pow(this._x-p._x, 2) + (Math.Pow(this._y-p._y, 2)));
//     }
// }

Console.Write("Введите число N: ");
int i = 1;

while (int.TryParse(Console.ReadLine(), out int n))
{
    while (i <= n)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i ++;
    }
}