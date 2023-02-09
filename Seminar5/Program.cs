// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// 1. Создаем и заполняем массив
// 2. Циклом проверяем отрицательные и положительные элементы массива
// 

// int[] array = GetRandomArray(12, -9, 9);
// int[] minAndMax = GetMinAndMaxFromArray(array);
// System.Console.WriteLine($"Введен массив {string.Join("", array)}");
// System.Console.WriteLine($"Сумма положительных {minAndMax[0]}, сумма отрицательных {minAndMax[1]}");

int [] GetRandomArray(int length, int min, int max)
{
    int[] array = new int [length];
    Random num = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = num.Next(min, max + 1);
    }
    return array;

}

int [] GetMinAndMaxFromArray(int[] array)
{
    int[] minAndMax = new int [2];
    
    for(int counter = 0; counter < array.Length; counter++)
    {
        if(array[counter] > 0)
        {
            minAndMax[0] = minAndMax[0] + array[counter];
        }
        else
        {
            minAndMax[1] = minAndMax[1] + array[counter];
        }
    }
    return minAndMax;
}

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int [] array = GetRandomArray(4, -9, 10);
// int[] changedArray = ChangeMarks(array);
// System.Console.WriteLine($"Выведены заданные элементы массива {string.Join(" ", array)} и изменненный массив {string.Join(" ", changedArray)}");

int [] ChangeMarks(int[] array)
{
    int[] changed = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        changed[i] = array[i] * (-1);
    }
    return changed;
}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int [] array = GetRandomArray(5, -9, 9);
int number = -3;
if(FindNumber(array, number))
{
    System.Console.WriteLine($"{string.Join(", ", array)} Да");
}
else System.Console.WriteLine($"{string.Join(", ", array)} Нет");

bool FindNumber(int[] array, int number)
{
    if (number < 0) number = number * -1;
    for(int i = 0; i < array.Length; i++)
    {
        int modul = array[i];
        if(modul < 0) modul = modul * -1;
        if(modul == number)
        {
            return true;
        }
    }
    return false;
}
